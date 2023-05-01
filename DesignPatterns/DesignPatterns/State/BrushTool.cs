namespace DesignPatterns.State;

public class BrushTool: ITool
{
    #region MouseUp

    public void MouseUp()
    {
        Console.WriteLine("Draw a line");
    }

    #endregion

    #region MouseDown

    public void MouseDown()
    {
        Console.WriteLine("Brush icon");
    }

    #endregion
}