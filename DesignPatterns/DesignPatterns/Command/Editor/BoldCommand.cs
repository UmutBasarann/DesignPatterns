namespace DesignPatterns.Command.Editor;

public class BoldCommand : IUndoableCommand
{
    #region Fields

    private string _prevContent = string.Empty;
    private readonly HtmlEditor _editor;
    private readonly History _history;

    #endregion

    #region Constructor

    public BoldCommand(HtmlEditor editor, History history)
    {
        _editor = editor;
        _history = history;
    }

    #endregion
    
    #region Execute

    public void Execute()
    {
        _prevContent = _editor.GetContent();
        _editor.MakeBold();
        _history.Push(this);
    }

    #endregion

    #region Unexecute

    public void Unexecute()
    {
        _editor.SetContent(_prevContent);
    }

    #endregion
}