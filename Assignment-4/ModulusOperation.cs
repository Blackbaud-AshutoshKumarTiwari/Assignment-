using System;

class ModulusOperation : ICalculatorOperation
{
    public string Name => "Modulus";

    public char Symbol => '%';

    public double Execute(
        double firstNumber,
        double secondNumber)
    {
        if (secondNumber == 0)
        {
            throw new DivideByZeroException(
                "Cannot perform modulus by zero.");
        }

        return firstNumber % secondNumber;
    }
}