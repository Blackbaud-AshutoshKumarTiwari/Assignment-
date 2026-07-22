using System;

class InputManager : IInputManager
{
    public int ReadOperationChoice()
    {
        Console.WriteLine();
        Console.Write("Enter your choice: ");

        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int choice))
        {
            throw new InvalidOperationException(
                "Please enter a valid number.");
        }

        return choice;
    }

    public double ReadNumber(
        string message)
    {
        Console.Write(message);

        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double number))
        {
            throw new InvalidOperationException(
                "Please enter a valid number.");
        }

        return number;
    }

    public bool AskToContinue()
    {
        Console.WriteLine();
        Console.Write(
            "Do you want to continue? (y/n): ");
        string? input = Console.ReadLine();

        return input != null &&
               input.ToLower() == "y";
    }
}