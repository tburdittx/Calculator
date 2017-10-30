using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4
{
    public class NumberCalculator

    {
        private static int PerformACalculation()
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
            }
            return answer;
        } 
        public void NumberCalculator2()
        {
            PerformACalculation();
        }
       
    }
}
