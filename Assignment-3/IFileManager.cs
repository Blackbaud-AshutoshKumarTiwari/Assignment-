using System.Collections.Generic;

interface IFileManager
{
    void SaveHistoryToFile(
        IReadOnlyList<string> calculationHistory);
}