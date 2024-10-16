namespace DesignPatterns.DesignPatterns.Behavioural.MementoPattern;

// Memento
public class EditorState
{
    private readonly string _title;
    private readonly string _content;

    // State metadata
    private readonly DateTime _stateCreatedAt;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedAt = DateTime.Now;
    }

    public string Title => _title;

    public string Content => _content;

    public DateTime StateCreatedAt => _stateCreatedAt;

    public override string ToString()
    {
        return $"Title: {_title}, Content: {_content}, Created At: {_stateCreatedAt}";
    }
}