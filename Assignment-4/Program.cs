using System;

class Program
{
    static void Main(string[] args)
    {
        IInputManager inputManager =
            new InputManager();

        IDisplayManager displayManager =
            new DisplayManager();

        IHistoryRepository historyRepository =
            new FileHistoryRepository();

        IOperationFactory operationFactory =
            new OperationFactory();

        Calculator calculator =
            new Calculator(
                inputManager,
                displayManager,
                historyRepository,
                operationFactory);

        calculator.Run();
    }
}