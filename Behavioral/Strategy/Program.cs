namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulates interchangeable algorithms and allows them to be selected at runtime.

            //Real-life analogy:
            //A "navigation app" lets you choose between different strategies(e.g., fastest route, shortest distance, or scenic route).

            Navigator navigator = new Navigator();

            navigator.SetStrategy(new FastestRoute());
            navigator.BuildRoute("Home", "Work");
            // Output: Building fastest route from Home to Work.

            navigator.SetStrategy(new ScenicRoute());
            navigator.BuildRoute("Home", "Park");
            // Output: Building scenic route from Home to Park.

        }
    }
}
