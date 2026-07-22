class SubtractionOperation: ICalculatorOperation
{
    public string Name => "Subtraction";
    public char Symbol => '-';

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        

        return firstNumber - secondNumber;
    }
}