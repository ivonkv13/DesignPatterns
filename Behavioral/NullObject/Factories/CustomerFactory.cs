// Factory
public class CustomerFactory
{
    private static readonly List<string> ExistingCustomers = new List<string> { "Alice", "Bob" };

    public static Customer GetCustomer(string name)
    {
        if (ExistingCustomers.Contains(name))
        {
            return new RealCustomer(name);
        }
        return new NullCustomer();
    }
}