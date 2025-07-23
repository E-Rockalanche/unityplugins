#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;

namespace Apple.CoreHaptics
{
    [Serializable]
    public class CHHapticEventParameter
    {
        public CHHapticEventParameterID ParameterID;
        public float ParameterValue;

        public CHHapticEventParameter() { }
        public CHHapticEventParameter(CHHapticEventParameterID id, float value)
        {
            ParameterID = id;
            ParameterValue = value;
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
