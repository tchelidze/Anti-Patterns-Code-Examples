namespace Bridge
{
    public class DvdRemote : RemoteControl
    {
        public bool Playing { get; protected set; }

        public DvdRemote(EntertainmentDevice entertainmentDevice) : base(entertainmentDevice)
        {
        }

        public override void ButtonNine()
        {
            Playing = !Playing;
        }
    }
}
