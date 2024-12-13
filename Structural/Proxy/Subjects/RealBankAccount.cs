public class RealBankAccount : IBankAccount
{
    private double _balance = 1000;

    public void Withdraw(double amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}, Remaining balance: ${_balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }
}
