using System.Collections.Generic;

interface IOperationFactory
{  //Factory Pattern
    ICalculatorOperation CreateOperation(
        int operationChoice);

    IReadOnlyList<ICalculatorOperation>
        GetOperations();
}