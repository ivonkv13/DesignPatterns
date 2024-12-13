using AbstractFactory.Factories.MacOS.Models;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories.MacOS
{
    public class MacOSFactory : IUIFactory
    {
        public IButton CreateButton() => new MacOSButton();
        public ITextbox CreateTextbox() => new MacOSTextbox();
    }
}