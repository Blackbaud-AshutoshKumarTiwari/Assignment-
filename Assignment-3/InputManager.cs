using System;
// Handle user Input
class InputManager : IInputManager
{
    public int ReadOperationChoice()
    {
        //SRP- Only reposible for the input handling  
        int operationChoice;

        Console.WriteLine("\nEnter your choice:");

        while (!int.TryParse(
            Console.ReadLine(),
            out operationChoice))
        {
            Console.WriteLine(
                "Invalid input. Please enter a valid number:");
        }

        return operationChoice;
    }

    public double ReadNumber(string inputMessage)
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

    public bool AskToContinue()
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