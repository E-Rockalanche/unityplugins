#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using System;
using System.Runtime.InteropServices;
using Apple.Core;
using Apple.Core.Runtime;

namespace Apple.GameKit.Multiplayer
{
    using GKMatchProperties = NSDictionary<NSString, NSObject>;

    /// <summary>
    /// An object that represents matchmaking results, including the players that join the match and their properties that matchmaking rules uses.
    /// </summary>
    [Introduced(iOS: "17.2", macOS: "14.2", tvOS: "17.2", visionOS: "1.1")]
    public class GKMatchedPlayers : NSObject
    {
        /// <summary>
        /// Construct a GKMatchedPlayers wrapper around an existing instance.
        /// </summary>
        /// <param name="gkMatchedPlayersPtr"></param>
        public GKMatchedPlayers(IntPtr gkMatchedPlayersPtr) : base(gkMatchedPlayersPtr) { }

        /// <summary>
        /// The local player's properties that matchmaking rules uses to find the players, with some additions.
        /// </summary>
        public GKMatchProperties Properties => PointerCast<GKMatchProperties>(Interop.GKMatchedPlayers_Properties(Pointer));

        /// <summary>
        /// The players that join the match.
        /// </summary>
        public NSArray<GKPlayer> Players => PointerCast<NSArray<GKPlayer>>(Interop.GKMatchedPlayers_Players(Pointer));

        /// <summary>
        /// The properties for other players that matchmaking rules uses to find players, with some additions.
        /// </summary>
        public NSDictionary<GKPlayer, GKMatchProperties> PlayerProperties => PointerCast<NSDictionary<GKPlayer, GKMatchProperties>>(Interop.GKMatchedPlayers_PlayerProperties(Pointer));

        private static class Interop
        {
            [DllImport(InteropUtility.DLLName)]
            public static extern IntPtr GKMatchedPlayers_Properties(IntPtr gkMatchedPlayersPtr);
            [DllImport(InteropUtility.DLLName)]
            public static extern IntPtr GKMatchedPlayers_Players(IntPtr gkMatchedPlayersPtr);
            [DllImport(InteropUtility.DLLName)]
            public static extern IntPtr GKMatchedPlayers_PlayerProperties(IntPtr gkMatchedPlayersPtr);
        }
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
