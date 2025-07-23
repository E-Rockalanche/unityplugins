#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System;
using System.Runtime.InteropServices;

namespace Apple.GameKit
{
    /// <summary>
    /// A type of challenge where a player must earn another player's achievement.
    /// </summary>
    public class GKAchievementChallenge : GKChallenge
    {
        internal GKAchievementChallenge(IntPtr pointer) : base(pointer)
        {
        }

        /// <summary>
        /// The achievement that the player must earn to complete the challenge.
        /// </summary>
        public GKAchievement Achievement => PointerCast<GKAchievement>(Interop.GKAchievementChallenge_GetAchievement(Pointer));

        private static class Interop
        {
            [DllImport(InteropUtility.DLLName)]
            public static extern IntPtr GKAchievementChallenge_GetAchievement(IntPtr pointer);
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
