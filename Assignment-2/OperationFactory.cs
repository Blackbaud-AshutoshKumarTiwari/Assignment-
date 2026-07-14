using System;

class OperationFactory
{
    public static CalculatorOperation CreateOperation(
        int operationChoice)
    {
        switch (operationChoice)
        {
            case (int)MenuChoice.Addition:
                return new AdditionOperation();

            case (int)MenuChoice.Subtraction:
                return new SubtractionOperation();

            case (int)MenuChoice.Multiplication:
                return new MultiplicationOperation();

            case (int)MenuChoice.Division:
                return new DivisionOperation();

            case (int)MenuChoice.Modulus:
                return new ModulusOperation();

            default:
                throw new InvalidOperationException(
                    "Invalid choice. Please select 1-6.");
        }
    }
}