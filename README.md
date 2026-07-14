# Calculator Console Application Assignment-2
**#WorkFlow**
Program.cs
    │
    ▼
Calculator.Run()
    │
    ▼
DisplayManager.DisplayMenu()
    │
    ▼
InputManager.ReadOperationChoice()
    │
    ▼
Is Clear History?
 ┌─────────────Yes─────────────┐
 │                             ▼
 │                    HistoryManager
 │                      ClearHistory()
 │                             │
 │                             ▼
 │                    DisplayManager
 │                     ShowHistory()
 │
 No
 │
 ▼
InputManager.ReadNumber()
(First Number)
 │
 ▼
InputManager.ReadNumber()
(Second Number)
 │
 ▼
OperationFactory.CreateOperation()
 │
 ▼
AdditionOperation /
SubtractionOperation /
MultiplicationOperation /
DivisionOperation /
ModulusOperation
 │
 ▼
Execute()
 │
 ▼
Result Returned
 │
 ▼
DisplayManager.DisplayResult()
 │
 ▼
HistoryManager.AddCalculation()
 │
 ▼
DisplayManager.ShowHistory()
 │
 ▼
InputManager.AskToContinue()
 │
 ├── Yes → Back to Menu
 │
 └── No
       │
       ▼
FileManager.SaveHistoryToFile()
       │
       ▼
HistoryFileName Constant
       │
       ▼
"calculator_history.txt"
       │
       ▼
File.WriteAllLines(
    HistoryFileName,
    calculationHistory)
       │
       ▼
File Created In:
bin\Debug\net8.0\
calculator_history.txt
       │
       ▼
DisplayManager.DisplayExitMessage()
       │
       ▼
END


