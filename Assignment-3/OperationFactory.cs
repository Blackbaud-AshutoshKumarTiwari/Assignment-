using System;
using System.Collections.Generic;

class OperationFactory : IOperationFactory
{
    //SRP-Only cretaes Operation objects 
    //OCP-Can be extended with new operation 
    private readonly Dictionary<int, ICalculatorOperation>
        operations;

    public OperationFactory(
        Dictionary<int, ICalculatorOperation> operations)
    {
        this.operations = operations;
    }

    public ICalculatorOperation CreateOperation(
        int operationChoice)
    {
        if (operations.ContainsKey(operationChoice))
        {
            return operations[operationChoice];
        }

        throw new InvalidOperationException(
            "Invalid choice. Please select a valid menu option.");
    }
}