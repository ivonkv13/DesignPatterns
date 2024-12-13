namespace AbstractFactory.Interfaces
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}