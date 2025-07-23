#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.GameController
{
    public class GCException : Exception
    {
        public int Code { get; private set; }
        public string LocalizedDescription { get; private set; }

        public GCException(GCError error)
        {
            Code = error.Code;
            LocalizedDescription = error.LocalizedDescription;
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
