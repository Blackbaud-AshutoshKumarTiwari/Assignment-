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

        File.WriteAllLines(
            HistoryFileName,
            calculationHistory);
    }
}