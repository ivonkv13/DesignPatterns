namespace Singleton
{
    public sealed class CentralBank
    {
        private static CentralBank? _instance;
        private static readonly object _lock = new object();

        private CentralBank() { }

        public static CentralBank Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new CentralBank();
                    return _instance;
                }
            }
        }

        public void PrintStatus() => Console.WriteLine("Central Bank is operational.");
    }
}
