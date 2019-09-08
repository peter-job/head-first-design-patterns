namespace RemoteControlWithPartyMode
{
    public class TvOffCommand : ICommand
    {
        Tv tv;

        public TvOffCommand(Tv tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.Off();
        }
    }
}
