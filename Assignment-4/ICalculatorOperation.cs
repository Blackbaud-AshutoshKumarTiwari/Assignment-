interface ICalculatorOperation
{
    string Name { get; }

    char Symbol { get; }

    double Execute(
        double firstNumber,
        double secondNumber);
}