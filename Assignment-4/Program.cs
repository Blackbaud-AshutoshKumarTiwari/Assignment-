using System;

class Program
{
    static void Main(string[] args)
    {
        // Transient Lifetime-A new object is created every time it is requested


        /*These objects are created once when the application starts 
        and passed to Calculator 

        They are not shared globally like Logger,
        They are used only for the calculator workflow,
        If needed, a new instance can be created without affecting other objects*/
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