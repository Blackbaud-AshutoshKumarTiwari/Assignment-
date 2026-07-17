using System;

class PowerOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Power; }
    }

    public string Name
    {
        get { return "Power"; }
    }

    public char Symbol
    {
        get { return '^'; }
    }

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        return Math.Pow(
            firstNumber,
            secondNumber);
    }
}