namespace DesignPatterns.Template;

public class GenerateReportTask: Task
{
    #region DoExecute

    protected override void DoExecute()
    {
        Console.WriteLine("Generate Report");
    }

    #endregion
}