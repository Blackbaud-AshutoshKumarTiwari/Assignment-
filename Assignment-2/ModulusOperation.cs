using System;

class ModulusOperation : CalculatorOperation
{
    public override char Symbol
    {
        get { return '%'; }
    }

    public override double Execute(
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