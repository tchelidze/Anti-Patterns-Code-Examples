using System;

namespace Bridge
{
    public class TvRemoteMute : RemoteControl
    {
        public TvRemoteMute(EntertainmentDevice entertainmentDevice)
            : base(entertainmentDevice) { }

        public override void ButtonNine()
        {
            Console.WriteLine("TV was muted");
        }
    }
}