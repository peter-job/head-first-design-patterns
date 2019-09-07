using System;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);
            LightOnCommand livingRoomLightOff =
                new LightOnCommand(livingRoomLight);

            LightOnCommand kitchenLightOn =
                new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff =
                new LightOffCommand(kitchenLight);

            CeilingFanHighCommand ceilingFanOn =
                new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff =
                new CeilingFanOffCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp =
                new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown =
                new GarageDoorCloseCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCd =
                new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff =
                new StereoOffCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            remote.OnButtonWasPressed(2);
            remote.OffButtonWasPressed(2);
            remote.OnButtonWasPressed(3);
            remote.OffButtonWasPressed(3);
        }
    }
}
