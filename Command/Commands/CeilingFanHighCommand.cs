namespace RemoteControl
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.High();
        }
    }
}
