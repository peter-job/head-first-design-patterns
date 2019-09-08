using System;

namespace RemoteControlWithUndo
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlWithUndo remote = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff =
                new LightOffCommand(livingRoomLight);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
        }
    }
}
