using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

// Assignment 1: Basic Calculator 

class Assignment1 {

    

   static void Main(string[] args)
    {
        List<string> calculationHistory = new List<string>();
        bool continueCalculating = true;

        Console.WriteLine("=== Calculator ===\n");

        while (continueCalculating)
        {
            try
            {
                DisplayMenu();

                int choice = ReadChoice();

                if (choice == 6)
                {
                    ClearHistory(calculationHistory);
                    ShowHistory(calculationHistory);

                    continueCalculating = AskToContinue();
                    continue;
                }

                double num1 = ReadNumber("Enter the first number:");
                double num2 = ReadNumber("Enter the second number:");

                char operation = GetOperator(choice);

                double result = Calculate(num1, num2, operation);

                string calculation =
                    $"The result of {num1} {operation} {num2} = {result}";

                Console.WriteLine("\n" + calculation);

                calculationHistory.Add(calculation);

                ShowHistory(calculationHistory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }

            continueCalculating = AskToContinue();
        }

        SaveHistoryToFile(calculationHistory);

        Console.WriteLine("\nThank you for using Calculator!");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nChoose Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Clear History");
    }

    static int ReadChoice()
    {
        Console.WriteLine("\nEnter your choice:");
        return Convert.ToInt32(Console.ReadLine());
    }

    static double ReadNumber(string message)
    {
        Console.WriteLine(message);
        return Convert.ToDouble(Console.ReadLine());
    }

    static char GetOperator(int choice)
    {
        switch (choice)
        {
            case 1:
                return '+';

            case 2:
                return '-';

            case 3:
                return '*';

            case 4:
                return '/';

            case 5:
                return '%';

            default:
                throw new InvalidOperationException(
                    "Invalid choice. Please select 1-6.");
        }
    }

    static double Calculate(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return Add(num1, num2);

            case '-':
                return Subtract(num1, num2);

            case '*':
                return Multiply(num1, num2);

            case '/':
                return Divide(num1, num2);

            case '%':
                return Modulus(num1, num2);

            default:
                throw new InvalidOperationException("Invalid operation.");
        }
    }

    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return num1 / num2;
    }

    static double Modulus(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot perform modulus by zero.");
        }

        return num1 % num2;
    }

    static bool AskToContinue()
    {
        Console.WriteLine("\nDo you want to perform another calculation? (y/n)");

        string response = Console.ReadLine();

        return response != null && response.ToLower() == "y";
    }

    static void ShowHistory(List<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            Console.WriteLine("\nNo calculations performed.");
            return;
        }

        Console.WriteLine("\n=== Calculation History ===");

        for (int i = 0; i < calculationHistory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {calculationHistory[i]}");
        }
    }

    static void SaveHistoryToFile(List<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            return;
        }

        try
        {
            string filePath = "calculator_history.txt";

            File.WriteAllLines(filePath, calculationHistory);

            Console.WriteLine($"\nHistory saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while saving history: " + ex.Message);
        }
    }

    static void ClearHistory(List<string> calculationHistory)
    {
        calculationHistory.Clear();
        Console.WriteLine("\nCalculation history cleared successfully.");
    }
}