using System;

class OperationFactory : IOperationFactory
{
    public ICalculatorOperation CreateOperation(
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

            case (int)MenuChoice.Power:
                return new PowerOperation();

            default:
                throw new InvalidOperationException(
                    "Invalid choice. Please select a valid menu option.");
        }
    }
}