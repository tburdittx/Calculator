using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4
{
    class DateCalculator
    {
        public int AnswerDate { get; set; }
        private static void CalculatingDate()
        {
            var date = AskForDate("Please enter a date in the form MM/DD/YYYY: ");
            var number = AskForNumber2("Please enter the number of days to add: ");
            var answer = date.AddDays(number);

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

        public void AnswerDate1()
        {
             CalculatingDate();  
            
        }
    }
   


}
