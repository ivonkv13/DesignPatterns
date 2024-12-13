using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories.Windows.Models
{
    public class WindowsTextbox : ITextbox
    {
        public void Render() => Console.WriteLine("Windows Textbox");
    }
}