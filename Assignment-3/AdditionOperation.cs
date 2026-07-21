class AdditionOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Addition; }
    }
    //OCP-New operation implementation
    //LSP-Can replace ICalculatorOperation
    public string Name
    {
        get { return "Addition"; }
    }

    public char Symbol
    {
        get { return '+'; }
    }

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
