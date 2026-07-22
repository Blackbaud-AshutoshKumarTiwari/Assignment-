using System;

class DivisionOperation : ICalculatorOperation
{
    public string Name => "Division";
    public char Symbol => '/';

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException(
                "Cannot divide by zero.");
        }

        return firstNumber / secondNumber;
    }
}