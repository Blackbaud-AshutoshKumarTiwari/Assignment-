class MultiplicationOperation : ICalculatorOperation
{
    public MenuChoice Choice
    {
        get { return MenuChoice.Multiplication; }
    }
    //OCP-New operation implementation
    //LSP-Can replace ICalculatorOperation
    public string Name
    {
        get { return "Multiplication"; }
    }

    public char Symbol
    {
        get { return '*'; }
    }

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber * secondNumber;
    }
}