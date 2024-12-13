namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Provides a default "do nothing" object that adheres to an interface, avoiding null checks.

            //Real-life analogy:
            //If you send a **notification**, and the recipient doesn’t exist, a “null” recipient could handle the request by doing nothing (instead of throwing an error).

            Customer customer1 = CustomerFactory.GetCustomer("Alice");
            Customer customer2 = CustomerFactory.GetCustomer("Eve");

            Console.WriteLine(customer1.GetCustomerDetails()); // Output: Customer Name: Alice
            Console.WriteLine(customer2.GetCustomerDetails()); // Output: No customer found.
        }
    }
}
        