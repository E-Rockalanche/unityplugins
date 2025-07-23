#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;
using UnityEngine;

namespace Apple.GameController
{
    #region Callback Type Definitions
    internal delegate void SuccessCallback();
    internal delegate void ErrorCallback(GCError error);
    #endregion
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
