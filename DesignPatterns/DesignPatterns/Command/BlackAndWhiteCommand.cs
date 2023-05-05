using DesignPatterns.Command.FX;

namespace DesignPatterns.Command;

public class BlackAndWhiteCommand : ICommand
{
    #region Execute

    public void Execute()
    {
        Console.WriteLine("B&W Filter");
    }

    #endregion
}