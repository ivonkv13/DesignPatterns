namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defines a one-to-many dependency between objects, so when one object changes state, all dependents are notified.

            //A "news agency" publishes updates, and subscribers (newspapers, apps) are notified.

            NewsPublisher publisher = new NewsPublisher();
            MobileApp app1 = new MobileApp("App1");
            MobileApp app2 = new MobileApp("App2");

            publisher.Subscribe(app1);
            publisher.Subscribe(app2);

            publisher.Notify("Breaking News: Observer Pattern Explained!");
            // Output:
            // App1 received: Breaking News: Observer Pattern Explained!
            // App2 received: Breaking News: Observer Pattern Explained!

            publisher.Unsubscribe(app2);
            publisher.Notify("Update: Observer Pattern Example Completed!");
            // Output:
            // App1 received: Update: Observer Pattern Example Completed!
        }
    }
}
