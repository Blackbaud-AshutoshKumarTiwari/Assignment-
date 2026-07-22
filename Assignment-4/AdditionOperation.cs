class AdditionOperation : ICalculatorOperation
{
    public string Name => "Addition";

    public char Symbol => '+';

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber + secondNumber;
    }
}