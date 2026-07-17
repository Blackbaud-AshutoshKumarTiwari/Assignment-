using System;

class DivisionOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Division; }
    }

    public string Name
    {
        get { return "Division"; }
    }

    public char Symbol
    {
        get { return '/'; }
    }

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