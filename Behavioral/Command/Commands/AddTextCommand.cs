public class AddTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly string _textToAdd;
    private bool _executed = false;

    public AddTextCommand(TextEditor editor, string textToAdd)
    {
        _editor = editor;
        _textToAdd = textToAdd;
    }

    public void Execute()
    {
        _editor.AddText(_textToAdd);
        _executed = true;
    }

    public void Undo()
    {
        if (_executed)
        {
            _editor.RemoveLastCharacters(_textToAdd.Length);
            _executed = false;
        }
    }
}
