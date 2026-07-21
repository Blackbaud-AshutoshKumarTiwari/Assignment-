using System.Collections.Generic;
//Defines history operation 
interface IHistoryManager
{  // ISP-Only history-related functionality
    
        void AddCalculation(string calculationDetails);

    void ClearHistory();

    IReadOnlyList<string> GetCalculationHistory();
}