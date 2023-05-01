using DesignPatterns.Strategy.Compressor;
using DesignPatterns.Strategy.Filter;

namespace DesignPatterns.Strategy;

public class ImageStorage
{
    #region Store

    public void Store(string fileName, ICompressor compressor, IFilter filter)
    {
        compressor.Compress(fileName);
        filter.Apply(fileName);
    }

    #endregion

    
}