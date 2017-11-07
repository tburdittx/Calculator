using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator2;
using NLog;

namespace Calc4
{
    class AskForCalculationMode
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;

        private void AskForCalculationMode1()
        {
            Program DateCalculator = new Program();
            Program NumberCalculator = new Program();
            Program AskForNumber = new Program();
            AskForNumber askForNumber = new AskForNumber();
            var LogCalculator = new Logger2();
            var LogDateCalculator = new Logger2();

            Console.WriteLine("Which calculator mode do you want?");
            Console.WriteLine("Press 1 for Numbers");
            Console.WriteLine("Press 2 for Dates");

            string message1 = "Please enter a number";
            Console.WriteLine(message1);
            int numbergiven = new int();
            numbergiven = int.Parse(Console.ReadLine());

            if (numbergiven == 1)
            {
                new NumberCalculator(LogCalculator).ListOfNumbers5();
            }
            else if (numbergiven == 2)
            {
                new DateCalculator(LogCalculator).AnswerDate1();
            }

        }
        public void AskForCalculationMode2()
        {
            AskForCalculationMode1();

        }



    }
}
