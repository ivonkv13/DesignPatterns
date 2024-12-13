
// Concrete Class
public class RealCustomer : Customer
{
    private string _name;

    public RealCustomer(string name) => _name = name;

    public override string GetCustomerDetails() => $"Customer Name: {_name}";
}
