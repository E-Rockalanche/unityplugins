#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
namespace Apple.CoreHaptics
{
	internal class CHHapticPlayerConfiguration
	{
		public CHHapticPattern Ahap { get; }
		public CHHapticPatternPlayer Player { get; }

		public CHHapticPlayerConfiguration(CHHapticPattern ahap, CHHapticPatternPlayer player)
		{
			Ahap = ahap;
			Player = player;
		}
	}
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
