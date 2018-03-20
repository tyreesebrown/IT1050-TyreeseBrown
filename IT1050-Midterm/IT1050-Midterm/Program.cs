using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            bool condition = true;
            while (condition == true)
            {
                Console.WriteLine("The condition is " + condition);
            }

            //Question 2
            int i = 1;
            while (i <= 7)
            {
                Console.WriteLine("[" + Math.Pow(2, i) + "]");
                i++;
            }

            //Question 3
            int i;
            for (i = 49; i >= 1; i--)
            {
                if (i == 1)
                    Console.WriteLine(i);
                else
                    Console.Write(i + ", ");
            }

            //Question 4
            int i = 1;
            while (i <= 21)
            {
                if (i == 21)
                    Console.WriteLine(i);
                else
                    Console.Write(i + "   ");
                i += 2;
            }

            //Question 5
            int n = 8;
            int i = 10; //initialize
            do
            {
                Console.Write("*");
                i++; //update!
            } while (i < n); //test condition

            //The difference between a while loop and a do-while loop in this scenario
            //is that there is still at least one output because the program writes before
            //the condtion is tested. If this were a while loop there would be no output because
            //the test condition is initially false.

            //Question 6
            bool icyRain = false;
            bool tornadoWarning = false;
            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }
        }
    }
}
