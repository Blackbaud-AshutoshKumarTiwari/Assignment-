using System;

class InputManager
{
    public  int ReadOperationChoice()
    {
        int operationChoice;

        Console.WriteLine("\nEnter your choice:");

        while (!int.TryParse(
            Console.ReadLine(),
            out operationChoice))
        {
            Console.WriteLine(
                "Invalid input. Please enter a number:");
        }

        return operationChoice;
    }

    public  double ReadNumber(string inputMessage)
    {
        double enteredNumber;

        Console.WriteLine(inputMessage);

        while (!double.TryParse(
            Console.ReadLine(),
            out enteredNumber))
        {
            Console.WriteLine(
                "Invalid input. Please enter a valid number:");
        }

        return enteredNumber;
    }

    public  bool AskToContinue()
    {
        Console.WriteLine(
            "\nDo you want to perform another calculation? (y/n)");

        string? userResponse = Console.ReadLine();

        return string.Equals(
            userResponse?.Trim(),
            "y",
            StringComparison.OrdinalIgnoreCase);
    }
}