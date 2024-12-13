public class File : IComponent
{
    private string _name;

    public File(string name) => _name = name;

    public void Display(int depth) => Console.WriteLine(new string('-', depth) + _name);
}
