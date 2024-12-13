namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Provides a placeholder to control access to an object.

            //Real-life analogy:
            //A credit/debit card acts as a proxy for your bank account

            IBankAccount account = new BankAccountProxy();
            account.Withdraw(200);
            // Proxy: Validating transaction...
            // Withdrawn: $200, Remaining balance: $800
        }
    }
}
