public class RemoveTextCommand : ICommand
{
    private readonly TextEditor _editor;
    private readonly int _length;
    private string _removedText = string.Empty;
    private bool _executed = false;

    public RemoveTextCommand(TextEditor editor, int length)
    {
        _editor = editor;
        _length = length;
    }

    public void Execute()
    {
        var currentContent = _editor.GetContent();
        if (_length <= currentContent.Length && _length > 0)
        {
            _removedText = currentContent.Substring(currentContent.Length - _length, _length);
            _editor.RemoveLastCharacters(_length);
            _executed = true;
        }
    }

    public void Undo()
    {
        if (_executed)
        {
            _editor.AddText(_removedText);
            _executed = false;
        }
    }
}
