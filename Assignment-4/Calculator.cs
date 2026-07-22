using System;
using System.Collections.Generic;

class Calculator
{
    private readonly IInputManager inputManager;

    private readonly IDisplayManager displayManager;

    private readonly IHistoryRepository historyRepository;

    private readonly IOperationFactory operationFactory;

    public Calculator(
        IInputManager inputManager,
        IDisplayManager displayManager,
        IHistoryRepository historyRepository,
        IOperationFactory operationFactory)
    {
        this.inputManager = inputManager;
        this.displayManager = displayManager;
        this.historyRepository = historyRepository;
        this.operationFactory = operationFactory;
    }

    public void Run()
    {
        bool continueCalculation = true;

        displayManager.DisplayWelcomeMessage();

        Logger.Instance.Log(
            "Calculator application started.");

        while (continueCalculation)
        {
            try
            {
                IReadOnlyList<ICalculatorOperation>
                    operations =
                        operationFactory.GetOperations();

                displayManager.DisplayMenu(operations);

                int choice =
                    inputManager.ReadOperationChoice();

                int historyChoice =
                    operations.Count + 1;

                int exitChoice =
                    operations.Count + 2;

                if (choice == historyChoice)
                {
                    DisplayCalculationHistory();
                }
                else if (choice == exitChoice)
                {
                    continueCalculation = false;
                }
                else
                {
                    PerformCalculation(choice);
                }

                if (continueCalculation)
                {
                    continueCalculation =
                        inputManager.AskToContinue();
                }
            }
            catch (Exception exception)
            {
                displayManager.DisplayErrorMessage(
                    exception.Message);

                Logger.Instance.Log(
                    "Error: " + exception.Message);
            }
        }

        displayManager.DisplayExitMessage();

        Logger.Instance.Log(
            "Calculator application closed.");
    }

    private void PerformCalculation(
        int operationChoice)
    {
        ICalculatorOperation operation =
            operationFactory.CreateOperation(
                operationChoice);

        double firstNumber =
            inputManager.ReadNumber(
                "Enter first number: ");

        double secondNumber =
            inputManager.ReadNumber(
                "Enter second number: ");

        double result =
            operation.Execute(
                firstNumber,
                secondNumber);

        string calculationDetails =
            $"{firstNumber} {operation.Symbol} " +
            $"{secondNumber} = {result}";

        displayManager.DisplayResult(
            calculationDetails);

        historyRepository.Save(
            calculationDetails);

        Logger.Instance.Log(
            "Calculation performed: " +
            calculationDetails);
    }

    private void DisplayCalculationHistory()
    {
        IReadOnlyList<string> calculationHistory =
            historyRepository.GetAll();

        displayManager.DisplayHistory(
            calculationHistory);

        Logger.Instance.Log(
            "Calculation history displayed.");
    }
}