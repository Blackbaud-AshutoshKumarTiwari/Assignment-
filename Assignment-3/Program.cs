class Program
{
    static void Main(string[] args)
    {
        IInputManager inputManager =
            new InputManager();

        IDisplayManager displayManager =
            new DisplayManager();

        IHistoryManager historyManager =
            new HistoryManager();

        IFileManager fileManager =
            new FileManager();

        IOperationFactory operationFactory =
            new OperationFactory();

        Calculator calculator =
            new Calculator(
                inputManager,
                displayManager,
                historyManager,
                fileManager,
                operationFactory);

        calculator.Run();
    }
}