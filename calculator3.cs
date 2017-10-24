using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");

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


            int answer = numbers[0];

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

            Console.WriteLine("The answer is: " + answer);

            Console.ReadLine();

        }
    }
}
