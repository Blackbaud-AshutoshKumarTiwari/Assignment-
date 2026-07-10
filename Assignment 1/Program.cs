using Microsoft.VisualBasic.FileIO;
//Assignment 1: Basic Calculator 
class Assignment1
{
    static void Main(string[] args)
    {

        Calculator calculator = new Calculator();
        try
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Operation u want to perform (Choose Addition +, Subtraction -, Multiplication *, Division   /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = calculator.Cal(num1, num2, op);
            Console.WriteLine($"The result of {num1} {op} {num2} = {result}");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }


}
class Calculator
{
    public double Cal(double num1, double num2, char op)
    {
        double result;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
 
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                break;
            default:
                throw new InvalidOperationException("Invalid operation Choose Any four operation given");
        }
        return result;
    }
}