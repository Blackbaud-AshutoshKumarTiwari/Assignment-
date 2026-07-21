//Define input contract
interface IInputManager
{
    int ReadOperationChoice(); // ISP-Only input-related Method 

    double ReadNumber(string inputMessage);

    bool AskToContinue();
}