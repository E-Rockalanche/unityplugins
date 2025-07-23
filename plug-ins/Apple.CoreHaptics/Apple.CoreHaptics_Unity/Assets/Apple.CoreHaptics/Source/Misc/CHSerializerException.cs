#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.CoreHaptics
{
    public class CHSerializerException : Exception
    {
        public CHSerializerException(string message) : base(message) { }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
