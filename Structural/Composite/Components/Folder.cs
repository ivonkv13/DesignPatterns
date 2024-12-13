public class Folder : IComponent
{
    private string _name;
    private List<IComponent> _children = new List<IComponent>();

    public Folder(string name) => _name = name;

    public void Add(IComponent component) => _children.Add(component);

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
        foreach (var child in _children)
        {
            child.Display(depth + 2);
        }
    }
}
