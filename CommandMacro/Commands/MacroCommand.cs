namespace RemoteControlWithPartyMode
{
    public class MacroCommand : ICommand
    {
        ICommand[] commands;
        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }
    }
}
