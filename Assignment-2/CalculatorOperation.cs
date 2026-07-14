abstract class CalculatorOperation
{
    public abstract char Symbol { get; }

    public abstract double Execute(
        double firstNumber,
        double secondNumber);
}
