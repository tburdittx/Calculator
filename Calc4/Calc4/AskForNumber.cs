using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc4;
using Calculator2;

namespace Calc4
{
    public class AskForNumber
    {
        private static void AskForNumber1()
        {
            string message1 = "Please enter a number";
            Console.WriteLine(message1);
            int numbergiven = new int();
            numbergiven = int.Parse(Console.ReadLine());
           // return numbergiven;

        }
        public void AskForNumber4()
        {
            AskForNumber1();
        }
    }
}
