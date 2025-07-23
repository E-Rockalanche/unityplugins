#if (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
namespace Apple.GameController.Controller
{
    public enum GCBatteryState : int
    {
        Unknown = -1,
        Discharging,
        Charging,
        Full
    }
}
#endif // (UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
