using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_TyreeseBrown
{
    class Program
    {
        static void Main(string[] args)
        {
             //Question 1
             string[] names = {"Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford"};
             Console.WriteLine("The second element is " + names[1] + ". And the last element is " + names[names.Length-1]);

             //Question 2
             int n;
             string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
             for (n = 0; n <= months.Length-1; n++)
                  Console.WriteLine(n + 1 + " " + months[n]);

             //Question 3
             string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };
             foreach (string element in seasons)
             {
                 Console.WriteLine(element);
             }

             //Question 4
             int[] intArray = new int[1000];
             Random random = new Random();
             int randomNumber;
 
            foreach (int element in intArray)
            { 
                randomNumber = random.Next(0, 100);
                Console.WriteLine(randomNumber);
            }

            //Question 5
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            while (i <= names.Length-1)
            {
                Console.WriteLine(names[i]);
                i++; 
            } //changing names[0] to names[i] and iterating i
            
        }
    }
}
