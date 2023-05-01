namespace DesignPatterns.State;

public class Canvas
{
    #region Fields

    private readonly ITool _currentTool;

    #endregion

    #region Consturctor

    public Canvas(ITool currentTool)
    {
        _currentTool = currentTool;
    }

    #endregion

    #region GetCurrentTool

    public ITool GetCurrentTool()
    {
        return _currentTool;
    }

    #endregion

    #region MouseUp

    public void MouseUp()
    {
        _currentTool.MouseUp();
    }

    #endregion

    #region MouseDown

    public void MouseDown()
    {
        _currentTool.MouseDown();
    }

    #endregion
}