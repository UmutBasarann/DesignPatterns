namespace DesignPatterns.memento;

public class History
{
    #region Fields

    private List<EditorState> _states = new List<EditorState>();

    #endregion

    #region Push

    public void Push(EditorState state)
    {
        _states.Add(state);
    }

    #endregion

    #region Pop

    public EditorState Pop()
    {
        int lastIndex = _states.Count - 1;
        EditorState state = _states.ElementAt(lastIndex);
        _states.Remove(state);
        return state;
    }

    #endregion
}