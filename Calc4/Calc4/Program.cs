using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc4;

namespace Calculator2
{
    class Program
    {

       
        static void Main(string[] args)
        {
            //PrintWelcomeMessage printwelcomemessage = new PrintWelcomeMessage();
            PrintWelcomeMessage.PrintWelcomeMessage1();
                      


            AskForCalculationMode askForCalculationMode = new AskForCalculationMode();
            askForCalculationMode.AskForCalculationMode2();


            //Code above works
            //Need to do try/catch method for num/date calc
            //Create an instance of class and then use that to refer to the class methods
            //Classes need constructors!!

           

            Console.ReadLine();
        }   
    }
}

