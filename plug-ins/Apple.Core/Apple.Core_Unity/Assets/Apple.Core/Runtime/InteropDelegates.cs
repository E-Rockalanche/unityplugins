#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;

namespace Apple.Core.Runtime
{
    public delegate void SuccessCallback();
    public delegate void SuccessCallback<TResponse>(TResponse response);
    public delegate void SuccessTaskCallback(long taskId);
    public delegate void SuccessTaskCallback<TResponse>(long taskId, TResponse response);
    public delegate void ErrorCallback(InteropError error);
    public delegate void NSErrorTaskCallback(long taskId, IntPtr errorPointer);
    public delegate void NSErrorCallback(IntPtr errorPointer);
    public delegate void NSExceptionCallback(IntPtr exceptionPointer);
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
