namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Captures and restores an object’s internal state without exposing its details.

            //Real-life analogy:
            //A "video game save system" stores and restores player progress.

            Game game = new Game { Level = "Level 1", Score = 100 };
            SaveManager saveManager = new SaveManager();

            // Save game state
            saveManager.AddSave(game.Save());

            game.Level = "Level 2";
            game.Score = 200;

            // Restore saved state
            game.Restore(saveManager.GetSave(0));
            Console.WriteLine($"Restored to {game.Level}, Score: {game.Score}");
            // Output: Restored to Level 1, Score: 100
        }
    }
}
