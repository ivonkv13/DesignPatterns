namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

            //Real-life analogy:
            //A "vending machine" behaves differently depending on its state: accepting money, dispensing products, or being out of order.

            IVendingMachineState readyState = new ReadyState();
            IVendingMachineState outOfStockState = new OutOfStockState();

            VendingMachine machine = new VendingMachine(readyState);

            machine.InsertMoney(); // Money inserted. Ready to dispense product.
            machine.DispenseProduct(); // Product dispensed.

            machine.SetState(outOfStockState);

            machine.InsertMoney(); // Cannot insert money. Out of stock.
            machine.DispenseProduct(); // Cannot dispense. Out of stock.
        }
    }
}
