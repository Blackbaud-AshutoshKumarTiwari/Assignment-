class SubtractionOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Subtraction; }
    }

    public string Name
    {
        get { return "Subtraction"; }
    }

    public char Symbol
    {
        get { return '-'; }
    }

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}