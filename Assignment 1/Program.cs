using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
//Assignment 1: Basic Calculator
class Assignment1
{
    static void Main(string[] args)
    {
        List<string> calculationHistory = new List<string>();
        bool continueCalculating = true;

        Console.WriteLine("=== Calculator ===\n");

        while (continueCalculating)
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nChoose Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = Convert.ToInt32(Console.ReadLine());

                char op;
             

                switch (choice)
                {
                    case 1:
                        op = '+';
                        break;
                    case 2:
                        op = '-';
                        break;
                    case 3:
                        op = '*';
                        break;
                    case 4:
                       op = '/';
                        break;
                        default:
        throw new InvalidOperationException(
            "Invalid choice. Please select 1-4.");
                }

                double result = Cal(num1, num2, op);

                string calculation =
                    $"The result of {num1} {op} {num2} = {result}";

                Console.WriteLine("\n" + calculation);

                calculationHistory.Add(calculation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }

            Console.WriteLine(
                "\nDo you want to perform another calculation? (y/n)");

            string response = Console.ReadLine();

            if (response != null && response.ToLower() == "y")
            {
                continueCalculating = true;
            }
            else
            {
                continueCalculating = false;
            }
        }

        if (calculationHistory.Count > 0)
        {
            Console.WriteLine("\n=== Calculation History ===");

            for (int i = 0; i < calculationHistory.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {calculationHistory[i]}");
            }

            try
            {
                string filePath = "calculator_history.txt";

                File.WriteAllLines(
                    filePath,
                    calculationHistory);

                Console.WriteLine(
                    $"\nHistory saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("\nNo calculations performed.");
        }

        Console.WriteLine("\nThank you for using Calculator!");
    }

    static double Cal(
        double num1,
        double num2,
        char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;

            case '-':
                return num1 - num2;

            case '*':
                return num1 * num2;

            case '/':
                if (num2 == 0)
                {
                    throw new DivideByZeroException(
                        "Cannot divide by zero.");
                }

                return num1 / num2;

            default:
                throw new InvalidOperationException(
                    "Invalid operation.");
        }
    }
}