namespace DesignPatterns.Strategy.Compressor;

public interface ICompressor
{
    // byte[] Compress(byte[] image);
    void Compress(string fileName);
}