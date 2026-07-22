interface IInputManager
{
    int ReadOperationChoice();

    double ReadNumber(
        string message);

    bool AskToContinue();
}