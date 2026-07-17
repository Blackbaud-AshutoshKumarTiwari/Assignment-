using System.Collections.Generic;

interface IHistoryManager
{
    void AddCalculation(string calculationDetails);

    void ClearHistory();

    IReadOnlyList<string> GetCalculationHistory();
}