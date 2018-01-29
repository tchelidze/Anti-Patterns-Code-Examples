using System;

namespace Bridge
{
    public class TvRemotePause : RemoteControl
    {
        public TvRemotePause(EntertainmentDevice entertainmentDevice) : base(entertainmentDevice)
        {
        }

        public override void ButtonNine()
        {
            Console.Write("Dvd was paused");
        }
    }
}