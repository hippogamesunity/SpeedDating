using UnityEngine;

namespace Assets.Scripts.Common
{
    public static class Log
    {
        public static int LogLevel = 0;

        public static void Debug(string format, params object[] args)
        {
            if (LogLevel >= 0)
            {
                UnityEngine.Debug.Log(string.Format(format, args));
            }
        }

        public static void Debug(object message)
        {
            Debug(message.ToString());
        }

        public static void Error(string format, params object[] args)
        {
            if (LogLevel >= 1)
            {
                UnityEngine.Debug.Log(string.Format(format, args));
            }
        }
    }
}