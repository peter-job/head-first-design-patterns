namespace RemoteControlWithUndo
{
    public class CeilingFanOffCommand : ICommand
    {
        CeilingFan ceilingFan;
        string prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void Undo()
        {
            if (prevSpeed == "Off")
            {
                ceilingFan.Off();
            }
            else if (prevSpeed == "Low")
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == "Medium")
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == "High")
            {
                ceilingFan.High();
            }
        }
    }
}
