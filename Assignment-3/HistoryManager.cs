using System.Collections.Generic;
//Store calculation history 
class HistoryManager : IHistoryManager
{   //SRP-Only manages history
    private readonly List<string> calculationHistory =
        new List<string>();

    public void AddCalculation(string calculationDetails)
    {
        calculationHistory.Add(calculationDetails);
    }

    public void ClearHistory()
    {
        calculationHistory.Clear();
    }

    public IReadOnlyList<string> GetCalculationHistory()
    {
        return calculationHistory;
    }
}