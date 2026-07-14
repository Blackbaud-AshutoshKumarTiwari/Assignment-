using System;
using System.Collections.Generic;

class DisplayManager
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("=== Calculator ===");
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("\nChoose Operation:");
        Console.WriteLine($"{(int)MenuChoice.Addition}. Addition");
        Console.WriteLine($"{(int)MenuChoice.Subtraction}. Subtraction");
        Console.WriteLine($"{(int)MenuChoice.Multiplication}. Multiplication");
        Console.WriteLine($"{(int)MenuChoice.Division}. Division");
        Console.WriteLine($"{(int)MenuChoice.Modulus}. Modulus");
        Console.WriteLine($"{(int)MenuChoice.ClearHistory}. Clear History");
    }

    public static void DisplayResult(string calculationDetails)
    {
        Console.WriteLine("\n" + calculationDetails);
    }

    public static void DisplayHistory(
        IReadOnlyList<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            Console.WriteLine("\nNo calculations performed.");
            return;
        }

        Console.WriteLine("\n=== Calculation History ===");

        for (int historyIndex = 0;
             historyIndex < calculationHistory.Count;
             historyIndex++)
        {
            Console.WriteLine(
                $"{historyIndex + 1}. {calculationHistory[historyIndex]}");
        }
    }

    public static void DisplayErrorMessage(string errorMessage)
    {
        Console.WriteLine("\nError: " + errorMessage);
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void DisplayExitMessage()
    {
        Console.WriteLine("\nThank you for using Calculator!");
    }
}