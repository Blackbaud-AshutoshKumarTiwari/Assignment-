using System.Collections.Generic;
using System.IO;

class FileHistoryRepository : IHistoryRepository
{
    private const string HistoryFileName =
        "calculator_history.txt";

    public void Save(
        string calculationDetails)
    {
        File.AppendAllText(
            HistoryFileName,
            calculationDetails + System.Environment.NewLine);
    }

    public IReadOnlyList<string> GetAll()
    {
        if (!File.Exists(HistoryFileName))
        {
            return new List<string>();
        }

        return File.ReadAllLines(HistoryFileName);
    }
}