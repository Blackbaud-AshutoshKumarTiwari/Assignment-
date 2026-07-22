using System.Collections.Generic;

interface IDisplayManager
{
    void DisplayWelcomeMessage();

    void DisplayMenu(
        IReadOnlyList<ICalculatorOperation> operations);

    void DisplayResult(
        string calculationDetails);

    void DisplayHistory(
        IReadOnlyList<string> calculationHistory);

    void DisplayErrorMessage(
        string errorMessage);

    void DisplayMessage(
        string message);

    void DisplayExitMessage();
}