interface IOperationFactory
{
    ICalculatorOperation CreateOperation(
        int operationChoice);
}