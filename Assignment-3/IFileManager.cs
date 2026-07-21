using System.Collections.Generic;
using System.ComponentModel;
//Defines file-saving contract
interface IFileManager
{  //ISP-Contains only file operation functionality
    void SaveHistoryToFile(
        IReadOnlyList<string> calculationHistory);
}