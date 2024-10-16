namespace DesignPatterns.DesignPatterns.Behavioural.MementoPattern;

// Caretaker
public class History
{
    private List<EditorState> _states = new List<EditorState>();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Backup(EditorState state)
    {
        _states.Add(state);
    }

    public void Undo()
    {
        if (_states.Count == 0)
        {
            return;
        }

        var lastState = _states.Last();
        _states.Remove(lastState);
        _editor.Restore(lastState);
    }

    public void ShowHistory()
    {
        Console.WriteLine();
        Console.WriteLine("History:");
        Console.WriteLine();

        foreach (var state in _states)
        {
            Console.WriteLine(state.ToString());
        }
    }
}