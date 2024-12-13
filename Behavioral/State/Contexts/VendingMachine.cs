// Context
public class VendingMachine
{
    private IVendingMachineState _currentState;

    public VendingMachine(IVendingMachineState initialState)
    {
        _currentState = initialState;
    }

    public void SetState(IVendingMachineState newState) => _currentState = newState;

    public void InsertMoney() => _currentState.InsertMoney();
    public void DispenseProduct() => _currentState.DispenseProduct();
}
