// Originator
public class Game
{
    public string Level { get; set; }
    public int Score { get; set; }

    public GameSave Save() => new GameSave(Level, Score);
        
    public void Restore(GameSave save)
    {
        Level = save.Level;
        Score = save.Score;
    }
}
