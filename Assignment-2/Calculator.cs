using System;
using System.IO;

class Calculator
{
    private readonly HistoryManager historyManager =
        new HistoryManager();
   
    public void Run()
    {
        bool continueCalculating = true;

        DisplayManager.DisplayWelcomeMessage();

        while (continueCalculating)
        {
            try
            {
                DisplayManager.DisplayMenu();

                int operationChoice =
                    InputManager.ReadOperationChoice();

                if (operationChoice == (int)MenuChoice.ClearHistory)
                {
                    HandleClearHistory();

                    continueCalculating =
                        InputManager.AskToContinue();

                    continue;
                }

                HandleCalculation(operationChoice);
            }
            catch (DivideByZeroException exception)
            {
                DisplayManager.DisplayErrorMessage(exception.Message);
            }
            catch (InvalidOperationException exception)
            {
                DisplayManager.DisplayErrorMessage(exception.Message);
            }
            catch (IOException exception)
            {
                DisplayManager.DisplayErrorMessage(exception.Message);
            }
            catch (Exception)
            {
                DisplayManager.DisplayErrorMessage(
                    "An unexpected error occurred.");
            }

            continueCalculating =
                InputManager.AskToContinue();
        }

        SaveAndExit();
    }

    private void HandleCalculation(int operationChoice)
    {
        double firstNumber =
            InputManager.ReadNumber("Enter the first number:");

        double secondNumber =
            InputManager.ReadNumber("Enter the second number:");

        CalculatorOperation selectedOperation =
            OperationFactory.CreateOperation(operationChoice);

        double calculationResult =
            selectedOperation.Execute(firstNumber, secondNumber);

        string calculationDetails =
            $"The result of {firstNumber} {selectedOperation.Symbol} {secondNumber} = {calculationResult}";

        DisplayManager.DisplayResult(calculationDetails);

        historyManager.AddCalculation(calculationDetails);

        DisplayManager.DisplayHistory(
            historyManager.GetCalculationHistory());
    }

    private void HandleClearHistory()
    {
        historyManager.ClearHistory();

        DisplayManager.DisplayMessage(
            "\nCalculation history cleared successfully.");

        DisplayManager.DisplayHistory(
            historyManager.GetCalculationHistory());
    }

    private void SaveAndExit()
    {
        FileManager.SaveHistoryToFile(
            historyManager.GetCalculationHistory());

        DisplayManager.DisplayExitMessage();
    }
}