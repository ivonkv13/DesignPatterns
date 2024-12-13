public class CharacterFactory
{
    private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

    public Character GetCharacter(char symbol, string font)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new Character(symbol, font);
        }

        return _characters[symbol];
    }
}