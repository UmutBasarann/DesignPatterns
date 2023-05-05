using DesignPatterns.Command.FX;

namespace DesignPatterns.Command;

public class ResizeCommand : ICommand
{
    #region Execute

    public void Execute()
    {
        Console.WriteLine("Resize");
    }

    #endregion
}