using System;
using System.Collections.Generic;
using System.IO;

class FileManager : IFileManager
{
    private const string HistoryFileName =
        "calculator_history.txt";

    public void SaveHistoryToFile(
        IReadOnlyList<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            return;
        }

        try
        {
            File.WriteAllLines(
                HistoryFileName,
                calculationHistory);

            Console.WriteLine(
                $"\nHistory saved to {HistoryFileName}");
        }
        catch (IOException exception)
        {
            Console.WriteLine(
                "Error while saving history: " +
                exception.Message);
        }
    }
}