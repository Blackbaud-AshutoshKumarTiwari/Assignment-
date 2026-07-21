using System.Collections.Generic;
//Definr display contract
interface IDisplayManager
{ 
   //ISP-Only dislay fn 
    void DisplayWelcomeMessage();

    void DisplayMenu();

    void DisplayResult(string calculationDetails);

    void DisplayHistory(
        IReadOnlyList<string> calculationHistory);

    void DisplayErrorMessage(string errorMessage);

    void DisplayMessage(string message);

    void DisplayExitMessage();
}