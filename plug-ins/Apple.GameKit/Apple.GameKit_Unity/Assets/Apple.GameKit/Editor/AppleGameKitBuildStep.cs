using Apple.Core;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using UnityEditor.iOS.Xcode;
#endif

namespace Apple.GameKit.Editor
{
    public class AppleGameKitBuildStep : AppleBuildStep
    {
        public override string DisplayName => "Apple.GameKit";
        public override BuildTarget[] SupportedTargets => new BuildTarget[] {BuildTarget.iOS, BuildTarget.tvOS, BuildTarget.StandaloneOSX, BuildTarget.VisionOS};

        [Tooltip("A message that tells the user why the app needs access to their Game Center friends list.")]
        public string FriendListUsageDescription;

        [Tooltip("Identifier of the iCloud container for saved games.")]
        public string SavedGameContainerIdentifier;

#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
        public override void OnProcessEntitlements(AppleBuildProfile _, BuildTarget buildTarget, string _1, PlistDocument entitlements)
        {
            entitlements.root.SetBoolean("com.apple.developer.game-center", true);

            if (!string.IsNullOrWhiteSpace(SavedGameContainerIdentifier))
            {
                var iCloudIds = entitlements.root.CreateArray("com.apple.developer.icloud-container-identifiers");
                iCloudIds.AddString(SavedGameContainerIdentifier);

                var services = entitlements.root.CreateArray("com.apple.developer.icloud-services");
                services.AddString("CloudDocuments");

                var ubiquityIds = entitlements.root.CreateArray("com.apple.developer.ubiquity-container-identifiers");
                ubiquityIds.AddString(SavedGameContainerIdentifier);
            }
        }

        public override void OnProcessInfoPlist(AppleBuildProfile appleBuildProfile, BuildTarget buildTarget, string pathToBuiltTarget, PlistDocument infoPlist)
        {
            if (!string.IsNullOrWhiteSpace(FriendListUsageDescription))
            {
                infoPlist.root.SetString("NSGKFriendListUsageDescription", FriendListUsageDescription);
            }
        }

        public override void OnProcessFrameworks(AppleBuildProfile _, BuildTarget buildTarget, string generatedProjectPath, PBXProject pbxProject)
        {
            if (Array.IndexOf(SupportedTargets, buildTarget) > -1)
            {
                AppleNativeLibraryUtility.ProcessWrapperLibrary(DisplayName, buildTarget, generatedProjectPath, pbxProject);
                AppleNativeLibraryUtility.AddPlatformFrameworkDependency("GameKit.framework", false, buildTarget, pbxProject);
            }
            else
            {
                Debug.LogWarning($"[{DisplayName}] No native library defined for Unity build target {buildTarget.ToString()}. Skipping.");
            }
        }
#endif
    }
}
