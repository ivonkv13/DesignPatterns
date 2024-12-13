public class OutOfStockState : IVendingMachineState
{
    public void InsertMoney() => Console.WriteLine("Cannot insert money. Out of stock.");
    public void DispenseProduct() => Console.WriteLine("Cannot dispense. Out of stock.");
}
