public class Character : ICharacter
{
    public char Symbol { get; }
    public string Font { get; }

    public Character(char symbol, string font)
    {
        Symbol = symbol;
        Font = font;
    }
}
