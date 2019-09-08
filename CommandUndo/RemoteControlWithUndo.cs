﻿namespace RemoteControlWithUndo
{
    public class RemoteControlWithUndo
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;

        public RemoteControlWithUndo()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            var s = "";
            s += "\n------ Remote Control -----\n";
            for (int i = 0; i < 7; i++)
            {
                s += string.Format("[slot {0}] {1}  {2}\n",
                    i, onCommands[i].ToString(), offCommands[i].ToString());
            }
            s += string.Format("[undo] {0}\n",
                    undoCommand.ToString());
            return s;
        }
    }
}
