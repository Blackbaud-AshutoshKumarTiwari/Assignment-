class SubtractionOperation : CalculatorOperation
{
    public override char Symbol
    {
        get { return '-'; }
    }

    public override double Execute(
        double firstNumber,
        double secondNumber)
    {
        return firstNumber - secondNumber;
    }
}