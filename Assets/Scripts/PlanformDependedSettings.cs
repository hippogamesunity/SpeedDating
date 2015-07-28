using OnePF;

namespace Assets.Scripts
{
    public static class PlanformDependedSettings
    {

        #if UNITY_ANDROID

        public const string StorePublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArE3aMNkBBEbxigYLgtfAWFJcQhitM7a7CbBo5NaH55dw2gS6/Q/lzBxuDtTw9LIpVJsIiJCyx1WJUYj6V9Ca08fzIPRDqw7PJG7IZM6ggPFnlXYB0CxfhXW8xEqeKWrZCyzK6yHeOYonInDgyunJ+PHJ+DijWpZabS5GqrxjanFlNdRu9DuSOEXm1jdSeMBcTAtn/ycIjb22lLUSp2zb3njm/e+tSQHqHzh5xUc8wf75yl9rYKgrnanJZo6qRIjcuwMEfR3+3ZTHlWwvFEyvHSM9opyT38CKh+pTblVyVdj12Wt/dK8G5iI5rFWwsxJbYJHfavlbRyN9aazlX5rYFQIDAQAB";
        public const string StorePublicKeyXml = "<RSAKeyValue><Modulus>rE3aMNkBBEbxigYLgtfAWFJcQhitM7a7CbBo5NaH55dw2gS6/Q/lzBxuDtTw9LIpVJsIiJCyx1WJUYj6V9Ca08fzIPRDqw7PJG7IZM6ggPFnlXYB0CxfhXW8xEqeKWrZCyzK6yHeOYonInDgyunJ+PHJ+DijWpZabS5GqrxjanFlNdRu9DuSOEXm1jdSeMBcTAtn/ycIjb22lLUSp2zb3njm/e+tSQHqHzh5xUc8wf75yl9rYKgrnanJZo6qRIjcuwMEfR3+3ZTHlWwvFEyvHSM9opyT38CKh+pTblVyVdj12Wt/dK8G5iI5rFWwsxJbYJHfavlbRyN9aazlX5rYFQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public const string AdBuddiz = "bdc2f780-6d67-4ad9-9545-5092d50bf19a";
        public static string StoreName = OpenIAB_Android.STORE_GOOGLE;
        public const string StoreLink = "https://play.google.com/store/apps/details?id=com.SpeedDating";
        public const string UnityAdsId = "58130";
        
        #elif UNITY_IPHONE

        public const string StorePublicKey = "41f95fc5fdbe455a963a21b411f9024f";
        public const string AdBuddiz = "e25543d7-2db3-40b8-bb08-d8896a4d2145";
        public static string StoreName = OpenIAB_iOS.STORE;
        public const string StoreLink = "itms-apps://itunes.apple.com/app/id_";
        public const string UnityAdsId = "58136";

        #else

        public const string StorePublicKey = null;
        public const string AdBuddiz = null;
        public static string StoreName = null;
        public const string StoreLink = null;
        public const string UnityAdsId = null;
        
        #endif
    }
}