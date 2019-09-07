namespace RemoteControl
{
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }
    }
}
