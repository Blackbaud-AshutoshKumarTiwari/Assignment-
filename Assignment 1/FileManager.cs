class FileManager
{
    private const string HistoryFileName = "calculator_history.txt";

    public static void SaveHistoryToFile(
        List<string> calculationHistory)
    {
        if (calculationHistory.Count == 0)
        {
            return;
        }

        try
        {
            File.WriteAllLines(
                HistoryFileName,
                calculationHistory);

            Console.WriteLine(
                $"\nHistory saved to {HistoryFileName}");
        }
        catch (IOException exception)
        {
            Console.WriteLine(
                "Error while saving history: " +
                exception.Message);
        }
    }
}