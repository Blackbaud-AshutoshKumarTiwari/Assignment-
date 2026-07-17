class AdditionOperation : ICalculatorOperation
{
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