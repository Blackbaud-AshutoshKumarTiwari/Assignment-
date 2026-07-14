# Calculator Console Application - Assignment 2

## Overview

A C# Console Calculator application developed using Object-Oriented Programming (OOP) principles.


## OOP Principles Implemented
Encapsulation
Abstraction
Inheritance
Polymorphism

## Project Structure

```text
Program.cs
Calculator.cs
MenuChoice.cs
InputManager.cs
DisplayManager.cs
HistoryManager.cs
FileManager.cs
CalculatorOperation.cs
AdditionOperation.cs
SubtractionOperation.cs
MultiplicationOperation.cs
DivisionOperation.cs
ModulusOperation.cs
OperationFactory.cs
```

## Workflow

```text
Program.cs
│
└── Main()
      │
      ▼
Creates Calculator Object
      │
      ▼
Calculator.Run()
      │
      ▼
DisplayManager.DisplayWelcomeMessage()
      │
      ▼
Start While Loop
(continueCalculating = true)
      │
      ▼
DisplayManager.DisplayMenu()
      │
      ▼
InputManager.ReadOperationChoice()
      │
      ▼
Is Choice = ClearHistory?
      │
 ┌────┴────┐
 │         │
Yes        No
 │          │
 ▼          ▼
HandleClearHistory()   HandleCalculation()
 │                      │
 ▼                      ▼
HistoryManager          InputManager
ClearHistory()          ReadNumber()
 │                      (First Number)
 ▼                      │
DisplayManager          ▼
DisplayMessage()        InputManager
 │                      ReadNumber()
 ▼                      (Second Number)
DisplayManager          │
DisplayHistory()        ▼
 │                      OperationFactory
 ▼                      CreateOperation()
AskToContinue()         │
                        ▼
                Create Operation Object
                        │
                        ▼
              AdditionOperation
              SubtractionOperation
              MultiplicationOperation
              DivisionOperation
              ModulusOperation
                        │
                        ▼
                    Execute()
                        │
                        ▼
                Calculation Result
                        │
                        ▼
                DisplayManager
                    DisplayResult()
                        │
                        ▼
                HistoryManager
                  AddCalculation()
                        │
                        ▼
                HistoryManager
              GetCalculationHistory()
                        │
                        ▼
                DisplayManager
                  DisplayHistory()
                        │
                        ▼
                AskToContinue()
                        │
          ┌─────────────┴─────────────┐
          │                           │
         Yes                          No
          │                           │
          ▼                           ▼
     Back to Menu              SaveAndExit()
                                      │
                                      ▼
                            FileManager
                           SaveHistoryToFile()
                                      │
                                      ▼
                           HistoryFileName
                       "calculator_history.txt"
                                      │
                                      ▼
                         File.WriteAllLines()
                                      │
                                      ▼
                         calculator_history.txt
                                      │
                                      ▼
                       DisplayManager
                     DisplayExitMessage()
                                      │
                                      ▼
                                     END
```



