using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Tyreese_Brown
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            int counter = 0;
            int year = 2018;
            while (counter < 20)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine(year);
                    counter++;
                }
                year++;
            }

            //Question 2
            int secretNumber = 15;
            int i = 1;
            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 100 to guess the secret number");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input > secretNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                    ++i;
                    continue;
                }
                else if (input < secretNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                    ++i;
                    continue;
                }
                else
                {
                    Console.WriteLine("You guessed the right number! It was " + secretNumber);
                    Console.WriteLine("It took you this many times to guess the right number: " + i);
                }
            }
            //Question 3
            string item;
            string allItems;
            double cost;
            double totalCost = 0;

            Console.Write("Please enter the next item: ");
            item = Convert.ToString(Console.ReadLine());
            allItems = item + "\n";
            Console.Write("Please enter the item cost: ");
            cost = Convert.ToDouble(Console.ReadLine());
            totalCost += cost;
            Console.Write("Press <enter> to continue, E to end: ");
            item = Convert.ToString(Console.ReadLine());

            while (item != "E")
            {
                if (item != "E")
                {
                    Console.Write("Please enter the next item: ");
                    item = Convert.ToString(Console.ReadLine());
                    allItems = allItems + item + "\n";
                    Console.Write("Please enter the item cost: ");
                    cost = Convert.ToDouble(Console.ReadLine());
                    totalCost += cost;
                }
                Console.Write("Press <enter> to continue, E to end: ");
                item = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("\n" + "Grocery Items:" + "\n" + allItems);
            Console.WriteLine("Total Cost: " + totalCost);
        }
    }
}
