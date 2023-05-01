namespace DesignPatterns.Iterator;

public class BrowseHistory
{
    #region Fields

    private List<string> _urls = new List<string>();

    #endregion

    #region Push

    public void Push(string url)
    {
        _urls.Add(url);
    }

    #endregion

    #region Pop

    public string Pop()
    {
        int lastIndex = _urls.Count - 1;
        string url = _urls.ElementAt(lastIndex);
        _urls.Remove(url);
        return url;
    }

    #endregion

    #region CreateIterator

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }

    #endregion

    #region Helper Iterator Class

    public class ListIterator : IIterator<string>
    {
        #region Fields

        private readonly BrowseHistory _history;
        private int _index = 0;

        #endregion

        #region Constructor

        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }

        #endregion
        
        #region Next

        public void Next()
        {
            _index++;
        }

        #endregion

        #region Current

        public string Current()
        {
            return _history._urls.ElementAt(_index);
        }

        #endregion

        #region HasNext

        public bool HasNext()
        {
            return _index < _history._urls.Count;
        }

        #endregion
    }

    #endregion
}