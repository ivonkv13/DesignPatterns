﻿public class CommandManager
{
    private readonly Stack<ICommand> _history = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            var lastCommand = _history.Pop();
            lastCommand.Undo();
        }
    }
}
