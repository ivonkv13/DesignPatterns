// Concrete States
public class ReadyState : IVendingMachineState
{
    public void InsertMoney() => Console.WriteLine("Money inserted. Ready to dispense product.");
    public void DispenseProduct() => Console.WriteLine("Product dispensed.");
}
