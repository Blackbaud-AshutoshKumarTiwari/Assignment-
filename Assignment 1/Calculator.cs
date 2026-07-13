using System;
using System.Collections.Generic;

class Calculator
{
    private List<string> calculationHistory = new List<string>();

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
                    HistoryManager.ClearHistory(calculationHistory);
                    HistoryManager.ShowHistory(calculationHistory);

                    continueCalculating =

                        InputManager.AskToContinue();

                    continue;
                }

                double firstNumber =
                    InputManager.ReadNumber("Enter the first number:");

                double secondNumber =
                    InputManager.ReadNumber("Enter the second number:");

                char selectedOperator =
                    OperationManager.GetOperator(operationChoice);

                double calculationResult =
                    OperationManager.Calculate(
                        firstNumber,
                        secondNumber,
                        selectedOperator);

                string calculationDetails =
                    $"The result of {firstNumber} {selectedOperator} {secondNumber} = {calculationResult}";

                DisplayManager.DisplayResult(calculationDetails);

                calculationHistory.Add(calculationDetails);

                HistoryManager.ShowHistory(calculationHistory);
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

        FileManager.SaveHistoryToFile(calculationHistory);

        DisplayManager.DisplayExitMessage();
    }
}