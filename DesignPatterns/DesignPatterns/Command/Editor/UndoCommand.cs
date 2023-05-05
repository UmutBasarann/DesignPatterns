namespace DesignPatterns.Command.Editor;

public class UndoCommand : ICommand
{
    #region Fields

    private History _history;

    #endregion

    #region Constructor

    public UndoCommand(History history)
    {
        _history = history;
    }

    #endregion
    
    #region Execute

    public void Execute()
    {
        if (_history.Count() > 0)
        {
            _history.Pop().Unexecute();
        }
    }

    #endregion
}