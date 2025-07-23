#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System.Runtime.InteropServices;

namespace Apple.Core.Runtime
{
    [StructLayout(LayoutKind.Sequential)]
    public struct InteropError
    {
        public int Code;
        public string LocalizedDescription;
        public string TaskId;
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
