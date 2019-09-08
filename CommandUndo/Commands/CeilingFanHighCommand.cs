namespace RemoteControlWithUndo
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan ceilingFan;
        string prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
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

    public class CeilingFanMediumCommand : ICommand
    {
        CeilingFan ceilingFan;
        string prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Medium();
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
