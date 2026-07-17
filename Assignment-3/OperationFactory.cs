using System;
using System.Collections.Generic;

class OperationFactory : IOperationFactory
{
    private readonly Dictionary<int, ICalculatorOperation>
        operations;

    public OperationFactory()
    {
        operations =
            new Dictionary<int, ICalculatorOperation>
            {
                {
                    (int)MenuChoice.Addition,
                    new AdditionOperation()
                },
                {
                    (int)MenuChoice.Subtraction,
                    new SubtractionOperation()
                },
                {
                    (int)MenuChoice.Multiplication,
                    new MultiplicationOperation()
                },
                {
                    (int)MenuChoice.Division,
                    new DivisionOperation()
                },
                {
                    (int)MenuChoice.Modulus,
                    new ModulusOperation()
                }
            };
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