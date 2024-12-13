namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulates requests as objects, allowing you to parameterize, queue, or log them.

            //Real-life analogy:
            //simplified text editor that supports commands like "Add Text" and "Remove Text." Each command will implement a common interface, store the state necessary to undo the action, and the editor will maintain a history of commands to enable undoing.


            TextEditor editor = new TextEditor();
            CommandManager commandManager = new CommandManager();

            commandManager.ExecuteCommand(new AddTextCommand(editor, "Hello "));
            commandManager.ExecuteCommand(new AddTextCommand(editor, "World!"));
            Console.WriteLine("Content after adding text: " + editor.GetContent());

            commandManager.Undo();
            Console.WriteLine("Content after undo: " + editor.GetContent());

            commandManager.ExecuteCommand(new RemoveTextCommand(editor, 3));
            Console.WriteLine("Content after removing last 3 chars: " + editor.GetContent());

            commandManager.Undo();
            Console.WriteLine("Content after undoing removal: " + editor.GetContent());
        }
    }
}
