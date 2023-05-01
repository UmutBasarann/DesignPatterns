namespace DesignPatterns.Strategy.Filter;

public class BlackAndWhiteFilter : IFilter
{
    #region Apply

    public void Apply(string fileName)
    {
        Console.WriteLine("Applying B&W filter...");
    }

    #endregion
}