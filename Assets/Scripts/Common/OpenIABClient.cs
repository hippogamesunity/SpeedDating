using System;
using System.Collections.Generic;
using System.Linq;
using OnePF;

namespace Assets.Scripts.Common
{
    // ReSharper disable InconsistentNaming
    public class OpenIABClient : IDisposable
    // ReSharper restore InconsistentNaming
    {
        public static bool EnableLog = false;

        public event Action<Purchase> Purchased = purchase => { };
        public event Action<Purchase> Consumed = purchase => { };
        public event Action RestoreCompleted = () => { };
        public event Action<string> Restored = sku => { };
        public event Action<string> Failed = error => { };

        private readonly Options _options;
        private State _state = State.Unknown;
        private string _sku;

        private enum State
        {
            Unknown,
            Ready,
            Busy
        }

        public OpenIABClient(Options options)
        {
            WriteLog("initializing client...");
            WriteLog("options.checkInventoryTimeoutMs: {0}", options.checkInventoryTimeoutMs);
            WriteLog("options.discoveryTimeoutMs: {0}", options.discoveryTimeoutMs);
            WriteLog("options.verifyMode: {0}", options.verifyMode);
            WriteLog("options.prefferedStoreNames: {0}", string.Join(", ", options.prefferedStoreNames));
            WriteLog("options.storeKeys: {0}", string.Join(", ", options.storeKeys.Select(i => string.Format("{0}:{1}", i.Key, i.Value.Substring(0, 10) + "...")).ToArray()));

            _options = options;

            WriteLog("subscribing events...");

            if (UnityEngine.Object.FindObjectOfType<OpenIABEventManager>() == null)
            {
                throw new Exception("OpenIABEventManager component missed, please add it to game scene");
            }

            OpenIABEventManager.billingSupportedEvent += BillingSupportedEvent;
            OpenIABEventManager.queryInventorySucceededEvent += QueryInventorySucceededEvent;

            OpenIABEventManager.purchaseSucceededEvent += purchase => CompleteTask(Purchased, "purchaseSucceededEvent", purchase);
            OpenIABEventManager.consumePurchaseSucceededEvent += purchase => CompleteTask(Consumed, "consumePurchaseSucceededEvent", purchase);
            OpenIABEventManager.transactionRestoredEvent += sku => CompleteTask(Restored, "transactionRestoredEvent", sku);
            OpenIABEventManager.restoreSucceededEvent += () => CompleteTask(RestoreCompleted, "restoreSucceededEvent");

            OpenIABEventManager.billingNotSupportedEvent += error => { CompleteTask(Failed, "billingNotSupportedEvent", error); _state = State.Unknown; };
            OpenIABEventManager.queryInventoryFailedEvent += error => CompleteTask(Failed, "queryInventoryFailedEvent", error);
            OpenIABEventManager.purchaseFailedEvent += (number, error) => CompleteTask(Failed, "purchaseFailedEvent", error);
            OpenIABEventManager.consumePurchaseFailedEvent += error => CompleteTask(Failed, "consumePurchaseFailedEvent", error);
            OpenIABEventManager.restoreFailedEvent += error => CompleteTask(Failed, "restoreFailedEvent", error);

            #if !UNITY_EDITOR

            OpenIAB.enableDebugLogging(true);

            #endif
        }

        public void MapSku(string storeName, Dictionary<string, string> map)
        {
            foreach (var sku in map)
            {
                WriteLog("mapping sku: {0}", sku);
                OpenIAB.mapSku(sku.Key, storeName, sku.Value);
            }
        }

        public bool Busy
        {
            get { return _state == State.Busy; }
        }

        public void PurchaseProduct(string sku)
        {
            WriteLog("starting purchase: {0}", sku);

            if (_state == State.Busy)
            {
                CompleteTask(Failed, "can't purchase product", "busy");
            }
            else
            {
                _sku = sku;
                _state = State.Busy;

                if (_state == State.Ready)
                {
                    WriteLog("quering inventory...");
                    OpenIAB.queryInventory();
                }
                else
                {
                    WriteLog("initializing OpenIAB...");
                    OpenIAB.init(_options);
                }
            }
        }

        public void ConsumeProduct(Purchase purchase, bool anyway = false)
        {
            WriteLog("starting consume: {0}", purchase.Sku);

            if (anyway)
            {
                OpenIAB.consumeProduct(purchase);
            }
            else
            {
                switch (_state)
                {
                    case State.Busy:
                        CompleteTask(Failed, "can't consume product", "busy");
                        break;
                    case State.Ready:
                        _state = State.Busy;
                        OpenIAB.consumeProduct(purchase);
                        break;
                    default:
                        CompleteTask(Failed, "ConsumeProduct", "not initialized");
                        break;
                }
            }
        }

        public void Restore()
        {
            WriteLog("starting restore...");

            if (_state == State.Busy)
            {
                CompleteTask(Failed, "can't restore purchases", "busy");
            }
            else
            {
                _sku = null;
                _state = State.Busy;

                if (_state == State.Ready)
                {
                    WriteLog("quering inventory...");
                    OpenIAB.queryInventory();
                }
                else
                {
                    WriteLog("initializing OpenIAB...");
                    OpenIAB.init(_options);
                }
            }
        }

        public void Dispose()
        {
            WriteLog("unbinding...");
            OpenIAB.unbindService();
        }

        private void CompleteTask(Action<string> action, string source, string param)
        {
            _state = State.Ready;
            WriteLog("{0}, param: {1}", source, param);
            action(param);
        }

        private void CompleteTask(Action<Purchase> action, string @event, Purchase purchase)
        {
            _state = State.Ready;
            WriteLog("{0}, json: {1}", @event, purchase.OriginalJson);
            action(purchase);
        }

        private void CompleteTask(Action action, string message)
        {
            _state = State.Ready;
            WriteLog(message);
            action();
        }

        private void WriteLog(string message, params object[] args)
        {
            if (EnableLog)
            {
                UnityEngine.Debug.Log(GetType().Name + ": " + string.Format(message, args));
            }
        }

        #region Event handlers

        private void BillingSupportedEvent()
        {
            WriteLog("billing supported, quering inventory...");
            OpenIAB.queryInventory();
        }

        private void QueryInventorySucceededEvent(Inventory inventory)
        {
            var purchases = inventory.GetAllPurchases();

            if (purchases.Any())
            {
                WriteLog("query inventory succeeded, purchases owned: {0}", string.Join(", ", purchases.Select(i => i.Sku).ToArray()));

                if (_sku == null)
                {
                    foreach (var purchase in purchases)
                    {
                        WriteLog("restoring owned purchase: {0}", purchase.Sku);
                        Purchased(purchase);
                    }
                }
                else
                {
                    var purchase = purchases.SingleOrDefault(i => i.Sku == _sku);

                    if (purchase != null)
                    {
                        WriteLog("restoring owned purchase: {0}", purchase.Sku);
                        Purchased(purchase);
                    }
                }
            }
            else
            {
                WriteLog("query inventory succeeded, owned purchases not found");
            }


            #if UNITY_IPHONE

            if (_sku == null)
            {
                WriteLog("restoring transactions (iOS)...");
                OpenIAB.restoreTransactions();
            }

            #endif

            #if UNITY_ANDROID || UNITY_WEBPLAYER

            if (_sku == null || inventory.HasPurchase(_sku))
            {
                CompleteTask(RestoreCompleted, "purchases successfully restored (inventory check)");
            }

            #endif

            else
            {
                WriteLog("purchasing product: {0}", _sku);
                OpenIAB.purchaseProduct(_sku, Convert.ToString(CRandom.GetRandom(0, 1000000)));
            }
        }

        #endregion
    }
}