#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System.Runtime.InteropServices;

namespace Apple.GameController
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GCError
    {
        public int Code;
        public string LocalizedDescription;
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
