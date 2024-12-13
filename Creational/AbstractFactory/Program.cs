using AbstractFactory.Factories;
using AbstractFactory.Factories.MacOS;
using AbstractFactory.Factories.Windows;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Provides an interface for creating families of related objects without specifying their concrete classes.

            //Real-Life Analogy:
            //An "UI toolkit" with Windows and MacOS themes.

            IUIFactory windowsFactory = new WindowsFactory();

            IButton windowsButton = windowsFactory.CreateButton();
            ITextbox windowsTextbox = windowsFactory.CreateTextbox();

            windowsButton.Render();     // Output: Windows Button
            windowsTextbox.Render();   // Output: Windows Textbox

            IUIFactory macFactory = new MacOSFactory();

            IButton macButton = macFactory.CreateButton();
            ITextbox macTextbox = macFactory.CreateTextbox();

            macButton.Render();        // Output: macOS Button
            macTextbox.Render();       // Output: macOS Textbox
        }
    }
}
