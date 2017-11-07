using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc4;
using NLog;
using NLog.Fluent;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger2();

            PrintWelcomeMessage.PrintWelcomeMessage1();
            logger.Logger4();
            for (; ; )

            {
                AskForCalculationMode askForCalculationMode = new AskForCalculationMode();
                askForCalculationMode.AskForCalculationMode2();
            }

        }
    }
}

