using System;

class ModulusOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Modulus; }
    }

    public string Name
    {
        get { return "Modulus"; }
    }

    public char Symbol
    {
        get { return '%'; }
    }

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException(
                "Cannot perform modulus by zero.");
        }

        return firstNumber % secondNumber;
    }
}