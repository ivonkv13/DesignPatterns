public class BankAccountProxy : IBankAccount
{
    private RealBankAccount _realBankAccount = new RealBankAccount();

    public void Withdraw(double amount)
    {
        Console.WriteLine("Proxy: Validating transaction...");
        _realBankAccount.Withdraw(amount);
    }
}