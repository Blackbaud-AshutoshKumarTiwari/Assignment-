using System;

class DivisionOperation : CalculatorOperation
{
    public override char Symbol
    {
        get { return '/'; }
    }

    public override double Execute(
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