using System;

class DisplayManager
{
    public static void DisplayWelcomeMessage()
    {
        Console.WriteLine("=== Calculator ===");
    }

    public static void DisplayMenu()
    {
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

    public static void DisplayErrorMessage(string errorMessage)
    {
        Console.WriteLine("\nError: " + errorMessage);
    }

    public static void DisplayExitMessage()
    {
        Console.WriteLine("\nThank you for using Calculator!");
    }
}