#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.CoreHaptics
{
    public class CHException : Exception
    {
        public int Code { get; private set; }
        public string LocalizedDescription { get; private set; }

        public CHException(CHError error)
        {
            Code = error.Code;
            LocalizedDescription = error.LocalizedDescription;
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
