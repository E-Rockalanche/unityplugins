#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.GameController.Controller
{
    public class ConnectionStateChangeEventArgs : EventArgs
    {
        public bool IsConnected;

        public ConnectionStateChangeEventArgs(bool isConnected)
        {
            IsConnected = isConnected;
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
