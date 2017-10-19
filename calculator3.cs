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

            Console.WriteLine("Enter your first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondNumber = int.Parse(Console.ReadLine());


            int answer = 0;

            if (operation == "+")
            {
                answer = firstNumber + secondNumber;
            }

            if (operation == "*")
            {
                answer = firstNumber * secondNumber;
            }

            if (operation == "-")
            {
                answer = firstNumber - secondNumber;
            }

            if (operation == "/")
            {
                answer = firstNumber / secondNumber;
            }
           
            Console.WriteLine("The answer is: " + answer);

            Console.ReadLine();

        }
    }
}
