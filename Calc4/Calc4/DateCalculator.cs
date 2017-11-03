using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Calc4;

namespace Calc4
{
    class DateCalculator
    {
        private Logger2 logger;
        private Logger2 logCalculator;

        public DateCalculator(Logger2 logCalculator)
        {
            this.logCalculator = logCalculator;
        }

        private static void CalculatingDate()
        {
            var date = AskForDate("Please enter a date in the form MM/DD/YYYY: ");
            var number = AskForNumber2("Please enter the number of days to add: ");
            var answer = date.AddDays(number);


            Logger2.LogDateCalculation(date, number, answer);
            Console.WriteLine("The answer is: {0:dd/MM/yyyy}", answer);
            Console.WriteLine();
        }

        private static DateTime AskForDate(string message)
        {
            DateTime date;

            do
            {
                Console.Write(message);
            } while (!DateTime.TryParse(Console.ReadLine(), out date));

            return date;
        }
        private static int AskForNumber2(string message)
        {
            int count;

            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out count));

            return count;
        }

        public DateTime AnswerDate1()
        {
             CalculatingDate();
            return AnswerDate1();
        }
    }
}
