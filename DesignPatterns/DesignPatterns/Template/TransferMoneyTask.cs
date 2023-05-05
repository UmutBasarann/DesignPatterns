namespace DesignPatterns.Template;

public class TransferMoneyTask : Task
{
    #region DoExecute

    protected override void DoExecute()
    {
        Console.WriteLine("Transfer Money");
    }

    #endregion
}