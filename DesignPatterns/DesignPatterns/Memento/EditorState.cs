namespace DesignPatterns.Memento;

public class EditorState
{
    #region Fields

    private readonly string _content;

    #endregion

    #region Constructor

    public EditorState(string content)
    {
        _content = content;
    }

    #endregion

    #region GetContent

    public string GetContent()
    {
        return _content;
    }

    #endregion
}