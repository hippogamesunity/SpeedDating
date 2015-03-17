using OnePF;

namespace Assets.Scripts
{
    public static class PlanformDependedSettings
    {

        #if UNITY_ANDROID

        public const string StorePublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAs6fjnOEqE8xpY2OLiQuw/eqdVOM+ESSrRhmXGutEfpghQJ7RcPjpo6o0/0grWoJ6ARGfWOLXUqIWTAu+WFuEi7f83wnZ4TgX9FsEP81W4vhvFrdcOS4ua5QxQnefNwxS91HLfIEDNw5Pmr6t8e5wZjRJOpObXx0HJHO8VwgZ5RjYj3KFtASX8s8NlwRM8BgkeTlp2kt5yoejzKltvAFI4mfLS3iwEOV9BAPKP/7A2Uz538qUIcMct+IGZyS16Vms6Z23opNMPrU+cP0QYeOSlqjNEf7LlxUusaNzmmw80l+ISLdrJ4jmkSGu4lQr7quzZtYXsqDOLXmdAA7pPJcMmwIDAQAB";
        public const string StorePublicKeyXml = "<RSAKeyValue><Modulus>s6fjnOEqE8xpY2OLiQuw/eqdVOM+ESSrRhmXGutEfpghQJ7RcPjpo6o0/0grWoJ6ARGfWOLXUqIWTAu+WFuEi7f83wnZ4TgX9FsEP81W4vhvFrdcOS4ua5QxQnefNwxS91HLfIEDNw5Pmr6t8e5wZjRJOpObXx0HJHO8VwgZ5RjYj3KFtASX8s8NlwRM8BgkeTlp2kt5yoejzKltvAFI4mfLS3iwEOV9BAPKP/7A2Uz538qUIcMct+IGZyS16Vms6Z23opNMPrU+cP0QYeOSlqjNEf7LlxUusaNzmmw80l+ISLdrJ4jmkSGu4lQr7quzZtYXsqDOLXmdAA7pPJcMmw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public const string AdBuddiz = "c4ea4c1c-f9a9-4313-88f5-ce78e889b2ec";
        public static string StoreName = OpenIAB_Android.STORE_GOOGLE;
        public const string StoreLink = "https://play.google.com/store/apps/details?id=com.SpeedDating";
        
        #elif UNITY_IPHONE

        public const string StorePublicKey = "";
        public const string AdBuddiz = "";
        public static string StoreName = OpenIAB_iOS.STORE;
        public const string StoreLink = "itms-apps://itunes.apple.com/app/id_";

        #else

        public const string StorePublicKey = null;
        public const string AdBuddiz = null;
        public static string StoreName = null;
        public const string StoreLink = null;
        
        #endif
    }
}