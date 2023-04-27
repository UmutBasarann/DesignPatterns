namespace DesignPatterns.State;

public class SelectionTool: ITool
{
    #region MouseUp

    public void MouseUp()
    {
        Console.WriteLine("Draw a dashed rectangle");
    }

    #endregion

    #region MouseDown

    public void MouseDown()
    {
        
        Console.WriteLine("Selection icon");
    }

    #endregion
}