using System;
using System.Collections.Generic;

class HistoryManager
{
    public static void ShowHistory(List<string> calculationHistory)
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

    public static void ClearHistory(List<string> calculationHistory)
    {
        calculationHistory.Clear();

        Console.WriteLine(
            "\nCalculation history cleared successfully.");
    }
}