namespace DesignPatterns.Command.Editor;

public class History
{
    #region Fields

    private List<IUndoableCommand> _undoableCommands = new List<IUndoableCommand>();

    #endregion

    #region Push

    public void Push(IUndoableCommand undoableCommand)
    {
        _undoableCommands.Add(undoableCommand);
    }

    #endregion

    #region Pop

    public IUndoableCommand Pop()
    {
        int lastIndex = _undoableCommands.Count - 1;
        IUndoableCommand command = _undoableCommands.ElementAt(lastIndex);
        _undoableCommands.Remove(command);
        return command;
    }

    #endregion

    #region Count

    public int Count()
    {
        return _undoableCommands.Count;
    }

    #endregion
}