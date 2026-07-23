using System;
using System.IO;
/*Singleton Lifetime-Only one object (instance) is created for the entire application 
Only one logger instance should exist because:
Logging should be centralized,
Multiple logger instances are unnecessary,
The same logger is shared across the application*/

class Logger
{      private static Logger? instance;

    private const string LogFileName =
        "calculator_log.txt";
    /*Prevents:
    new Logger();
    from outside the class*/
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
