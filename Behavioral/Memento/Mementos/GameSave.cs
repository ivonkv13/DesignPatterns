
// Memento
public class GameSave
{
    public string Level { get; }
    public int Score { get; }

    public GameSave(string level, int score)
    {
        Level = level;
        Score = score;
    }
}
