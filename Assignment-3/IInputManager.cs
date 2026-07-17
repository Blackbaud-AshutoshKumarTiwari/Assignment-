interface IInputManager
{
    int ReadOperationChoice();

    double ReadNumber(string inputMessage);

    bool AskToContinue();
}