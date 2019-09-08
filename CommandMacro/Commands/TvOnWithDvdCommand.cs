namespace RemoteControlWithPartyMode
{
    public class TvOnWithDvdCommand : ICommand
    {
        Tv tv;

        public TvOnWithDvdCommand(Tv tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
            tv.SetDvd();
        }
    }
}
