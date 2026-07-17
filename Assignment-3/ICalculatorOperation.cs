interface ICalculatorOperation
{
    char Symbol { get; }

    double Execute(
        double firstNumber,
        double secondNumber);
}