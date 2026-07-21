using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {// all required objects and injects them into Calculator.
        IInputManager inputManager =
            new InputManager();

        IDisplayManager displayManager =
            new DisplayManager();

        IHistoryManager historyManager =
            new HistoryManager();

        IFileManager fileManager =
            new FileManager();
        // DIP used - Calculator depends on interfaces instead of concrete classes.

        Dictionary<int, ICalculatorOperation>
            operations =
                new Dictionary<int, ICalculatorOperation>
        {
            {
                (int)MenuChoice.Addition,
                new AdditionOperation()
            },
            {
                (int)MenuChoice.Subtraction,
                new SubtractionOperation()
            },
            {
                (int)MenuChoice.Multiplication,
                new MultiplicationOperation()
            },
            {
                (int)MenuChoice.Division,
                new DivisionOperation()
            },
            {
                (int)MenuChoice.Modulus,
                new ModulusOperation()
            }
        };

        IOperationFactory operationFactory =
            new OperationFactory(
                operations);

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