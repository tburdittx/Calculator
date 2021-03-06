﻿using System;
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

        enum Operation
        {
           Plus,
            Minus,
            Multiply,
            Divide
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
                if (!int.TryParse(input, out int value))
                {
                    //error
                }
                else
                {
                    numbersInput.Add(value);
                }
            }

            int answer = 0;

            switch (operation)
            {
                case "+":
                    answer = numbersInput.Sum();
                    break;
                case "-":
                    answer = numbersInput.Skip(1).Aggregate(numbersInput[0], (acc, number) => acc - number);
                    break;
                case "*":
                    answer = numbersInput.Aggregate(1, (acc, number) => acc * number);
                    break;
                case "/":
                    answer = numbersInput.Skip(1).Aggregate(numbersInput[0], (acc, number) => acc / number);
                    break;
                default: Console.WriteLine("Could not apply operator");
                    break;
            }
            Console.WriteLine(answer);
        }
        private void PerformACalculation()
        {
            ListOfNumbers5();
        }
    }
}
