// Caretaker
public class SaveManager
{
    private List<GameSave> _saves = new List<GameSave>();

    public void AddSave(GameSave save) => _saves.Add(save);

    public GameSave GetSave(int index) => _saves[index];
}