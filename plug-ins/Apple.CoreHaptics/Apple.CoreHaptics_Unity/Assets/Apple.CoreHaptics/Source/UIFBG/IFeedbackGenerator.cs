#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
namespace Apple.UIFBG
{
	public interface IFeedbackGenerator
	{
		void Prepare();
		void Destroy();
		void Trigger();
	}
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
