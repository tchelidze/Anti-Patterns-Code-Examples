namespace Bridge
{
    public abstract class RemoteControl
    {
        protected readonly EntertainmentDevice EntertainmentDevice;

        protected RemoteControl(
            EntertainmentDevice entertainmentDevice)
            => EntertainmentDevice = entertainmentDevice;

        public void ButtonFivePressed() => EntertainmentDevice.ButtonFivePressed();

        public void ButtonSixPressed() => EntertainmentDevice.ButtonSixPressed();

        public void DeviceFeedback() => EntertainmentDevice.Feedback();

        public abstract void ButtonNine();
    }
}