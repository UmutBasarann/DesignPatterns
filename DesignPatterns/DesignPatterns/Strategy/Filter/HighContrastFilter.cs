namespace DesignPatterns.Strategy.Filter;

public class HighContrastFilter: IFilter
{
    #region Apply

    public void Apply(string fileName)
    {
        Console.WriteLine("Applying High Contrast filter...");
    }

    #endregion
}