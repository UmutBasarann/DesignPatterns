namespace DesignPatterns.Command.FX;

public class Button
{
    #region Fields

    private string _label = string.Empty;
    private readonly ICommand _command;

    #endregion

    #region Constructor

    public Button(ICommand command)
    {
        _command = command;
    }

    #endregion

    #region Click

    public void Click()
    {
        _command.Execute();
    }

    #endregion

    #region Get

    public string GetLabel()
    {
        return _label;
    }

    #endregion

    #region Set

    public void SetLabel(string label)
    {
        _label = label;
    }

    #endregion
}