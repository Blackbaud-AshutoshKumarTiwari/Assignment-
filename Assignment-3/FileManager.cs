using System.Collections.Generic;
using System.IO;
//Save history to file 
class FileManager : IFileManager
{   //SRP-Only responsible for file operations
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