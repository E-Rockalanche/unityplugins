#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System.Runtime.InteropServices;
using UnityEngine;

namespace Apple.Core
{
    public class AppleLogger
    {
        private static AppleLogger instance = null;

        public AppleLogger()
        {
            Application.logMessageReceivedThreaded += AppleLog;
        }

        public AppleLogger Instance => instance ??= new AppleLogger();

        private void AppleLog(string msg, string trace, LogType t)
        {
            var logMessage = new System.Text.StringBuilder();
            logMessage.Append($"{t}\t{msg}\t{trace}");

            NSLog(logMessage.ToString());
        }

        [DllImport(InteropUtility.DLLName, EntryPoint = "AppleCore_NSLog")]
        internal static extern void NSLog(string msg);
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
