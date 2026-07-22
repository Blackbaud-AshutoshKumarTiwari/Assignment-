using System.Collections.Generic;

interface IOperationFactory
{
    ICalculatorOperation CreateOperation(
        int operationChoice);

    IReadOnlyList<ICalculatorOperation>
        GetOperations();
}