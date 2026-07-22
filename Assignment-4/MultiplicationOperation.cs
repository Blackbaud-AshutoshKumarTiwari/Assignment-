class MultiplicationOperation  : ICalculatorOperation
{
    public string Name => "Multiplication";
    public char Symbol => '*';

    public double Execute(
        double firstNumber,
        double secondNumber)
    {

        return firstNumber * secondNumber;
    }
}