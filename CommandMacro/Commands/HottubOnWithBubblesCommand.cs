namespace RemoteControlWithPartyMode
{
    public class HottubOnWithBubblesCommand : ICommand
    {
        Hottub hottub;

        public HottubOnWithBubblesCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.On();
            hottub.SetBubbles();
        }
    }
}
