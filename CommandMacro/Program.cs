using System;

namespace RemoteControlWithPartyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light light = new Light("Living Room");
            Tv tv = new Tv("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOnCommand lightOff = new LightOnCommand(light);

            TvOnWithDvdCommand tvOn = new TvOnWithDvdCommand(tv);
            TvOffCommand tvOff = new TvOffCommand(tv);

            StereoOnWithCdCommand stereoOn =
                new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            HottubOnWithBubblesCommand hottubOn =
                new HottubOnWithBubblesCommand(hottub);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);
            Console.WriteLine("-----Pressing Macro On Button-----");
            remote.OnButtonWasPressed(0);
            Console.WriteLine("-----Pressing Macro Off Button-----");
            remote.OffButtonWasPressed(0);
        }
    }
}
