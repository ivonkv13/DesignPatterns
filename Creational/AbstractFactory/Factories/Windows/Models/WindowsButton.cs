using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories.Windows.Models
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Windows Button");
    }
}