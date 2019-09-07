﻿namespace RemoteControl
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
