using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4
{
    public class Logger2
    {
        private const string LogFile = @"C:\Work\Calculator\CalculatorLog.log";

      //  public Logger2 Logger3 { get; set; }

        public static void LoggerFile()
        {
            if (File.Exists(LogFile))
            {
                File.Delete(LogFile);
            }
            else
            {
                File.Create(LogFile);
            }
        }

        public static void LogCalculation(int answer, int numbers, string operation)
        {
            File.AppendAllText(LogFile, string.Format("{0} = {1}{2}{3}", answer, operation, numbers, Environment.NewLine));
        }

        public static void LogDateCalculation(DateTime date, int number, DateTime answer)
        {
            File.AppendAllText(LogFile, string.Format(string.Format("{0}+{1}={2}{3}", date, number, answer, Environment.NewLine)));
        }

        public void Logger4()
        {
            LoggerFile();
        }
        public Logger2()
        {

        }

    }

}
