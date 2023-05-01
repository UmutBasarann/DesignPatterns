using DesignPatterns.Iterator;

var history = new BrowseHistory();
history.Push("a");
history.Push("b");
history.Push("c");

IIterator<string> iterator = history.CreateIterator();
while (iterator.HasNext())
{
    string url = iterator.Current();
    Console.WriteLine(url);
    iterator.Next();
}