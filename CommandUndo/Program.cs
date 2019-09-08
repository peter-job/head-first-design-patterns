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

            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanMediumCommand ceilingFanMedium = 
                new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh =
                new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff =
                new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(2, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPressed();
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPressed();

            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            Console.WriteLine(remote);
            remote.UndoButtonWasPressed();
            remote.OnButtonWasPressed(2);
            Console.WriteLine(remote);
            remote.UndoButtonWasPressed();
        }
    }
}
