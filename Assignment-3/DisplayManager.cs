using System;
using System.Collections.Generic;
//Handle all the console outputs
class DisplayManager : IDisplayManager
{    // SRP-Only output responsibility.
    private const string WelcomeMessage =
        "=== SOLID Calculator Application ===";

    private const string HistoryTitle =
        "=== Calculation History ===";

    private const string ExitMessage =
        "Thank you for using Calculator!";

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void DisplayWelcomeMessage()
    {
        DisplayMessage(WelcomeMessage);
    }

    public void DisplayMenu()
    {
        DisplayMessage("\nChoose Operation:");

        DisplayMessage(
            $"{(int)MenuChoice.Addition}. Addition");

        DisplayMessage(
            $"{(int)MenuChoice.Subtraction}. Subtraction");

        DisplayMessage(
            $"{(int)MenuChoice.Multiplication}. Multiplication");

        DisplayMessage(
            $"{(int)MenuChoice.Division}. Division");

        DisplayMessage(
            $"{(int)MenuChoice.Modulus}. Modulus");

        DisplayMessage(
            $"{(int)MenuChoice.Power}. Power");

        DisplayMessage(
            $"{(int)MenuChoice.ClearHistory}. Clear History");
    }

    public void DisplayResult(
        string calculationDetails)
    {
        DisplayMessage(
            $"\n{calculationDetails}");
    }

    public void DisplayHistory(
        IReadOnlyList<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            DisplayMessage(
                "\nNo calculations performed.");

            return;
        }

        DisplayMessage(
            $"\n{HistoryTitle}");

        for (
            int historyIndex = 0;
            historyIndex < calculationHistory.Count;
            historyIndex++)
        {
            DisplayMessage(
                $"{historyIndex + 1}. " +
                calculationHistory[historyIndex]);
        }
    }

    public void DisplayErrorMessage(
        string errorMessage)
    {
        DisplayMessage(
            $"\nError: {errorMessage}");
    }

    public void DisplayExitMessage()
    {
        DisplayMessage(
            $"\n{ExitMessage}");
    }
}