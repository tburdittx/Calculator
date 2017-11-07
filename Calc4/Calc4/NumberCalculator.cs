using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Calc4;
using System.Collections;

namespace Calc4
{
    public class NumberCalculator
    {
        private Logger2 logCalculator;


        /*
        private Logger2 logger;
        private Action<int, int, string> logCalculation;

        public NumberCalculator(Logger2 logger3)
        {
            logger3 = logger;
        }

        public NumberCalculator(Action<int, int, string> logCalculation)
        {
            this.logCalculation = logCalculation;
        }
*/
        public NumberCalculator(Logger2 logCalculator)
        {
            this.logCalculator = logCalculator;
        }

        public void ListOfNumbers5()
        {
            Console.WriteLine("Enter your operator");
            string operation = Console.ReadLine();
            List<int> numbersInput = new List<int>();

            Console.WriteLine("Please enter your number");
            string input = Console.ReadLine();
            numbersInput.Add(int.Parse(input));

            while (input != "")
            {
                Console.WriteLine("Please enter your next number: ");
                input = Console.ReadLine();
                int value;
                if (!int.TryParse(input, out value))
                {
                    //error
                }
                else
                {
                    numbersInput.Add(value);
                }
            }

            int answer = 0;

            if (operation == "*")
            {
                answer = numbersInput.Aggregate(1, (acc, number) => acc *number);
            }
            else if (operation == "/")
            {
                answer = numbersInput.Skip(1).Aggregate(numbersInput[0], (acc, number) => acc / number);
            }
            else if (operation == "+")
            {
                answer = numbersInput.Sum();
            }

            else if (operation == "-")
            {
                answer = numbersInput.Skip(1).Aggregate(numbersInput[0], (acc, number) => acc - number);
            }

            Console.WriteLine(answer);
        }

        private void PerformACalculation()
        {
            ListOfNumbers5();
        }
    }
}
