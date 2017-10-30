using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator2;

namespace Calc4
{
    class AskForCalculationMode

    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;

     //   public int Numbergiven { get; private set; }

        private void AskForCalculationMode1()
        {
            Program DateCalculator = new Program();
            Program NumberCalculator = new Program();
            Program AskForNumber = new Program();
            AskForNumber askForNumber = new AskForNumber();

            //Fix number display in the console window
            Console.WriteLine("Which calculator mode do you want?");
            Console.WriteLine(" {0}) Numbers", NumberCalculator);
            Console.WriteLine(" {0}) Dates", DateCalculator);

            string message1 = "Please enter a number";
            Console.WriteLine(message1);
            int numbergiven = new int();
            numbergiven = int.Parse(Console.ReadLine());
           // return numbergiven;

            if (numbergiven == 1)
            {
                NumberCalculator numberCalculator = new NumberCalculator();
                numberCalculator.NumberCalculator2();
            }
            else if (numbergiven == 2)
            {
                DateCalculator dateCalculator = new DateCalculator();
                dateCalculator.AnswerDate1();
            }
        }
        public void AskForCalculationMode2()
        {
            AskForCalculationMode1();
            
        }
        

       
    }
}
