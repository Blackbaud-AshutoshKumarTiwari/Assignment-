using System;
using System.IO;

class Calculator
{
    private readonly InputManager inputManager =
        new InputManager();

    private readonly DisplayManager displayManager =
        new DisplayManager();

    private readonly FileManager fileManager =
        new FileManager();

    private readonly HistoryManager historyManager =
        new HistoryManager();

    public void Run()
    {
        bool continueCalculating = true;

        displayManager.DisplayWelcomeMessage();

        while (continueCalculating)
        {
            try
            {
                displayManager.DisplayMenu();

                int operationChoice =
                    inputManager.ReadOperationChoice();

                if (operationChoice ==
                    (int)MenuChoice.ClearHistory)
                {
                    HandleClearHistory();

                    continueCalculating =
                        inputManager.AskToContinue();

                    continue;
                }

                HandleCalculation(operationChoice);
            }
            catch (DivideByZeroException exception)
            {
                displayManager.DisplayErrorMessage(
                    exception.Message);
            }
            catch (InvalidOperationException exception)
            {
                displayManager.DisplayErrorMessage(
                    exception.Message);
            }
            catch (IOException exception)
            {
                displayManager.DisplayErrorMessage(
                    exception.Message);
            }
            catch (Exception)
            {
                displayManager.DisplayErrorMessage(
                    "An unexpected error occurred.");
            }

            continueCalculating =
                inputManager.AskToContinue();
        }

        SaveAndExit();
    }

    private void HandleCalculation(
        int operationChoice)
    {
        double firstNumber =
            inputManager.ReadNumber(
                "Enter the first number:");

        double secondNumber =
            inputManager.ReadNumber(
                "Enter the second number:");

        CalculatorOperation selectedOperation =
            OperationFactory.CreateOperation(
                operationChoice);

        double calculationResult =
            selectedOperation.Execute(
                firstNumber,
                secondNumber);

        string calculationDetails =
            $"The result of {firstNumber} " +
            $"{selectedOperation.Symbol} " +
            $"{secondNumber} = " +
            $"{calculationResult}";

        displayManager.DisplayResult(
            calculationDetails);

        historyManager.AddCalculation(
            calculationDetails);

        displayManager.DisplayHistory(
            historyManager.GetCalculationHistory());
    }

    private void HandleClearHistory()
    {
        historyManager.ClearHistory();

        displayManager.DisplayMessage(
            "\nCalculation history cleared successfully.");

        displayManager.DisplayHistory(
            historyManager.GetCalculationHistory());
    }

    private void SaveAndExit()
    {
        fileManager.SaveHistoryToFile(
            historyManager.GetCalculationHistory());

        displayManager.DisplayExitMessage();
    }
}