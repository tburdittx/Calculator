using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Calc4;

namespace Calc4
{
    public class NumberCalculator
    {
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

        public int answer { get; private set; }
        public int UserInputOfHowMany { get; set; }
        public string operation { get; set; }

        private int PerformACalculation()
        {
            Console.WriteLine("Enter your operator");
            string operation = Console.ReadLine();

            Console.WriteLine("How many numbers do you want to " + operation);
            int UserInputOfHowMany = int.Parse(Console.ReadLine());

            int[] numbers = new int[UserInputOfHowMany];
            for (int i = 0; i < UserInputOfHowMany; i++)
            {
                Console.WriteLine("Please enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int answer = 0;

            for (int i = 0; i < UserInputOfHowMany; i++)
            {
                if (operation == "+")
                {
                    answer = answer + numbers[i];
                }

                if (operation == "*")
                {
                    answer = answer * numbers[i];
                }

                if (operation == "-")
                {
                    answer = answer - numbers[i];
                }

                if (operation == "/")
                {
                    answer = answer / numbers[i];
                }

                Logger2.LogCalculation(answer, numbers[i], operation);
            }
            Console.WriteLine(answer);
            return answer;
        }
        public int NumberCalculator2()
        {
            PerformACalculation();
            return answer;
        }
    }
}
