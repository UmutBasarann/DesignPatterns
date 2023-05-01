namespace DesignPatterns.Strategy.Compressor;

public class JpegCompressor : ICompressor
{
    #region Compress

    public void Compress(string fileName)
    {
        Console.WriteLine("Compressing using JPEG...");
    }

    #endregion
}