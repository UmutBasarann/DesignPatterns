using DesignPatterns.Command.FX;

namespace DesignPatterns.Command;

public class CompositeCommand : ICommand
{
    #region Fields

    private List<ICommand> _commands = new List<ICommand>();

    #endregion

    #region AddCommand

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    #endregion
    
    
    #region Execute

    public void Execute()
    {
        foreach (ICommand command in _commands)
        {
            command.Execute();
        }
    }

    #endregion
}