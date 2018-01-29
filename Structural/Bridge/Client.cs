namespace Bridge
{
    public class Client
    {
        public void Main()
        {
            RemoteControl controlMute = new TvRemoteMute(new TvDevice(1, 200));
            RemoteControl controlPause = new TvRemotePause(new TvDevice(1, 200));
            RemoteControl controlDvd = new DvdRemote(new DvdDevice());
        }
    }
}