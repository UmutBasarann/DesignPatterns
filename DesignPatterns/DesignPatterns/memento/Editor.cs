namespace DesignPatterns.memento;

public class Editor
{
    #region Fields

    private string _content = string.Empty;

    #endregion

    #region GetContent

    public string GetContent()
    {
        return _content;
    }

    #endregion

    #region SetContent

    public void SetContent(string content)
    {
        _content = content;
    }

    #endregion

    #region CreateState

    public EditorState CreateState()
    {
        return new EditorState(_content);
    }

    #endregion

    #region Restore

    public void Restore(EditorState state)
    {
        _content = state.GetContent();
    }

    #endregion
}