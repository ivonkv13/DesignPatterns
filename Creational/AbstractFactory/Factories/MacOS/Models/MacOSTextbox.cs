using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories.MacOS.Models
{
    internal class MacOSTextbox : ITextbox
    {
        public void Render() => Console.WriteLine("macOS Textbox");
    }
}