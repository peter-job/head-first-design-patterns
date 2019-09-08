namespace RemoteControlWithPartyMode
{
    public class HottubOffCommand : ICommand
    {
        Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.Off();
        }
    }
}
