namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ensure a class has only one instance and provide a global point of access.

            //Real-Life Analogy:
            //Think of a "government's central bank".
            //There’s only one central bank responsible for controlling the money supply.

            CentralBank bank1 = CentralBank.Instance;
            CentralBank bank2 = CentralBank.Instance;

            bank1.PrintStatus(); // Central Bank is operational.

            Console.WriteLine(ReferenceEquals(bank1, bank2)); // Verifying that there is only one instance.
        }
    }
}
