public class LevelTwoSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Intermediate Issue")
            Console.WriteLine("Level Two Support handled the issue.");
        else if (NextHandler != null)
            NextHandler.HandleRequest(request);
    }
}
