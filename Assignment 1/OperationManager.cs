using System;
using System.Diagnostics.Metrics;

class OperationManager
{
    public static char GetOperator(int operationChoice)
    {
        switch (operationChoice)
        {
            case(int)MenuChoice.Addition:
                return '+';

            case (int)MenuChoice.Subtraction:
            return '-';

        case (int)MenuChoice.Multiplication:
            return '*';

        case (int)MenuChoice.Division:
            return '/';

        case (int)MenuChoice.Modulus:
            return '%';

        default:
            throw new InvalidOperationException(
                          "Invalid choice.");


        }
    }

    public static double Calculate(
        double firstNumber,
        double secondNumber,
        char selectedOperator)
    {
        switch (selectedOperator)
        {
            case '+':
                return Add(firstNumber, secondNumber);

            case '-':
                return Subtract(firstNumber, secondNumber);

            case '*':
                return Multiply(firstNumber, secondNumber);

            case '/':
                return Divide(firstNumber, secondNumber);

            case '%':
                return Modulus(firstNumber, secondNumber);

            default:
                throw new InvalidOperationException(
                    "Invalid operation.");
        }
    }

    public static double Add(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public static double Subtract(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    public static double Multiply(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    public static double Divide(
        double firstNumber,
        double secondNumber)
    {
        if (secondNumber == 0)
            throw new DivideByZeroException(
                "Cannot divide by zero.");

        return firstNumber / secondNumber;
    }

    public static double Modulus(
        double firstNumber,
        double secondNumber)
    {
        if (secondNumber == 0)
            throw new DivideByZeroException(
                "Cannot perform modulus by zero.");

        return firstNumber % secondNumber;
    }
}