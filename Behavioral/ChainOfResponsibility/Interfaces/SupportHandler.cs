
// Handler Interface
public abstract class SupportHandler
{
    protected SupportHandler NextHandler;

    public void SetNextHandler(SupportHandler handler) => NextHandler = handler;

    public abstract void HandleRequest(string request);
}
