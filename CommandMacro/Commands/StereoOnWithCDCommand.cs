namespace RemoteControlWithPartyMode
{
    public class StereoOnWithCdCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCd();
            stereo.SetVolume(11);
        }
    }
}
