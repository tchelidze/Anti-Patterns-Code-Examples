namespace Bridge
{
    public abstract class EntertainmentDevice
    {
        public int DeviceState { get; set; }

        public int MaxSettings { get; set; }

        public int VolumeLevel { get; set; } = 0;

        public abstract void ButtonFivePressed();

        public abstract void ButtonSixPressed();

        public void ButtonSevenPressed() => ++VolumeLevel;

        public void ButtonEightPressed() => --VolumeLevel;

        public void Feedback()
        {
            if (DeviceState > MaxSettings || DeviceState < 0)
                DeviceState = 0;
        }
    }
}