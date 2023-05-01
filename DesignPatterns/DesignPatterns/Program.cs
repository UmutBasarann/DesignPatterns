using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Compressor;
using DesignPatterns.Strategy.Filter;

var storage = new ImageStorage();
storage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
storage.Store("a", new PngCompressor(), new HighContrastFilter());