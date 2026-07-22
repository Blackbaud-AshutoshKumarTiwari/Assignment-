using System;
using System.Collections.Generic;

class DisplayManager : IDisplayManager
{
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine(
            "Welcome to Calculator Application");
    }

    public void DisplayMenu(
        IReadOnlyList<ICalculatorOperation> operations)
    {
        Console.WriteLine();
        Console.WriteLine("Select Operation:");

        for (int index = 0;
     index < operations.Count;
     index++)
        {
            Console.WriteLine(
                $"{index + 1}. {operations[index].Name}");
        }

        Console.WriteLine(
            $"{operations.Count + 1}. View History");

        Console.WriteLine(
            $"{operations.Count + 2}. Exit");
    }

    public void DisplayResult(
        string calculationDetails)
    {
        Console.WriteLine();
        Console.WriteLine("Result:");
        Console.WriteLine(calculationDetails);
    }

    public void DisplayHistory(
        IReadOnlyList<string> calculationHistory)
    {
        Console.WriteLine();
        Console.WriteLine("Calculation History:");

        if (calculationHistory.Count == 0)
        {
            Console.WriteLine("No history found.");
            return;
        }

        foreach (string history in calculationHistory)
        {
            Console.WriteLine(history);
        }
    }

    public void DisplayErrorMessage(
        string errorMessage)
    {
        Console.WriteLine();
        Console.WriteLine("Error: " + errorMessage);
    }

    public void DisplayMessage(
        string message)
    {
        Console.WriteLine(message);
    }

    public void DisplayExitMessage()
    {
        Console.WriteLine();
        Console.WriteLine(
            "Thank you for using Calculator Application.");
    }
}