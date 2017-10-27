using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;
        static void Main(string[] args)
        {
            PrintWelcomeMessage();

            while (true)
            {
                int calculationMode = AskForCalculationMode();
                if (calculationMode == NumberCalculator)
                {
                    PerformACalculation();
                }
                else
                {
                    CalculatingDate();
                }
            }
        }
        private static int AskForCalculationMode()
        {
            Console.WriteLine("Which calculator mode do you want?");
            Console.WriteLine(" {0}) Numbers", NumberCalculator);
            Console.WriteLine(" {0}) Dates", DateCalculator);
            return AskForNumber("> ");
        }

        public static int AskForNumber(string message)
        {
            string message1 = "Please enter a number";
            Console.WriteLine(message1);
            int numbergiven = new int();
            numbergiven = int.Parse(Console.ReadLine());
            return numbergiven;
        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public static void PerformACalculation()
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
            Console.WriteLine("This is the answer: " + answer);
            Console.ReadLine();

        }
        public static void CalculatingDate()
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
    }
}

