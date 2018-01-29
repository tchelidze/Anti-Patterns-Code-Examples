namespace Bridge
{
    public class TvDevice : EntertainmentDevice
    {
        public TvDevice(int deviceState, int maxSettings)
        {
            DeviceState = deviceState;
            MaxSettings = maxSettings;
        }

        public override void ButtonFivePressed() => --DeviceState;

        public override void ButtonSixPressed() => ++DeviceState;
    }
}