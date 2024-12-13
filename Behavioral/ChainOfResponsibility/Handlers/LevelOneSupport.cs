// Concrete Handlers
public class LevelOneSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Basic Issue")
            Console.WriteLine("Level One Support handled the issue.");
        else if (NextHandler != null)
            NextHandler.HandleRequest(request);
    }
}
