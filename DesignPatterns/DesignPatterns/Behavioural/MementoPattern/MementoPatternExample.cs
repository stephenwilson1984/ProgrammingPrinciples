namespace DesignPatterns.DesignPatterns.Behavioural.MementoPattern;

public static class MementoPatternExample
{
    public static void Run()
    {
        var editor = new Editor();
        var history = new History(editor);

        editor.Title = "Title 1";
        editor.Content = "Content 1";
        history.Backup(editor.CreateState());

        editor.Title = "Title 2";
        editor.Content = "Content 2";
        history.Backup(editor.CreateState());

        editor.Title = "Title 3";
        editor.Content = "Content 3";
        history.Backup(editor.CreateState());

        history.ShowHistory();

        history.Undo();
        history.ShowHistory();

        history.Undo();
        history.ShowHistory();

        history.Undo();
        history.ShowHistory();
    }
}