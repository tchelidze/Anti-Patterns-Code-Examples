using System;

namespace Bridge
{
    public class DvdDevice : EntertainmentDevice
    {
        public override void ButtonFivePressed()
        {
            Console.WriteLine("Dvd skip chapter");
            DeviceState--;
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine("Dvd next chapter");
            DeviceState++;
        }
    }
}