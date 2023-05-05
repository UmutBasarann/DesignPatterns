namespace DesignPatterns.Command.Editor;

public class HtmlEditor
{
    #region Fields

    private string _content = string.Empty;

    #endregion

    #region MakeBold

    public void MakeBold()
    {
        _content = "<b>" + _content + "</b>";
    }

    #endregion

    #region Get

    public string GetContent()
    {
        return _content;
    }

    #endregion

    #region Set

    public void SetContent(string content)
    {
        _content = content;
    }

    #endregion
}