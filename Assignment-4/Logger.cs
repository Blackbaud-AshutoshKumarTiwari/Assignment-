using System;
using System.IO;

class Logger
{  //Singleton Pattern
    private static Logger? instance;

    private const string LogFileName =
        "calculator_log.txt";

    private Logger()
    {
    }

    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }
    }

    public void Log(string message)
    {
        string logMessage =
            $"{DateTime.Now}: {message}";

        File.AppendAllText(
            LogFileName,
            logMessage +
            Environment.NewLine);
    }
}
