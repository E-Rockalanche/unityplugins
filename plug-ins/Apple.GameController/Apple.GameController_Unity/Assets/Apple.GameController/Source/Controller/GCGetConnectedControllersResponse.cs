#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;
using System.Runtime.InteropServices;

namespace Apple.GameController.Controller
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GCGetConnectedControllersResponse
    {
        public IntPtr ControllersPtr;
        public int ControllersCount;

        public GCControllerHandle[] GetControllers()
        {
            var results = new GCControllerHandle[ControllersCount];
            var size = Marshal.SizeOf<GCControllerHandle>();

            for (var i = 0; i < ControllersCount; i++)
            {
                var elementPtr = new IntPtr((long)ControllersPtr + (i * size));
                results[i] = Marshal.PtrToStructure<GCControllerHandle>(elementPtr);
            }

            return results;
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
