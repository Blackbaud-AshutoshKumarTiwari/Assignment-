//Defines operation creation contract
interface IOperationFactory
{
    ICalculatorOperation CreateOperation(
        int operationChoice);
}
// DIP-Depends on abstraction