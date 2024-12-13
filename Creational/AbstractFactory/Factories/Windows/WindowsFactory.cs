using AbstractFactory.Factories.Windows.Models;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories.Windows
{
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ITextbox CreateTextbox() => new WindowsTextbox();
    }
}