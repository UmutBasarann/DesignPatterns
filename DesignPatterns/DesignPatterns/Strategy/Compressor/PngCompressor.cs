namespace DesignPatterns.Strategy.Compressor;

public class PngCompressor: ICompressor
{
    #region Compress

    public void Compress(string fileName)
    {
        Console.WriteLine("Compressing using PNG...");
    }

    #endregion
}