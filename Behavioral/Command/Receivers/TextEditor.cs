using System.Text;

public class TextEditor
{
    private StringBuilder _text = new StringBuilder();

    public void AddText(string newText)
    {
        _text.Append(newText);
    }

    public void RemoveLastCharacters(int length)
    {
        if (length <= 0 || length > _text.Length) return;
        _text.Remove(_text.Length - length, length);
    }

    public string GetContent() => _text.ToString();
}
