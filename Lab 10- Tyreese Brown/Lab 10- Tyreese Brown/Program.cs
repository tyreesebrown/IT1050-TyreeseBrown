using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10__Tyreese_Brown
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            var fruits = new[] { "apple", "mango", "orange", "apricot", "cherry", "grape", "blueberry" };
            foreach (var element in fruits)
                Console.WriteLine(element);

            //Question 2
            IEnumerable<string> fruitquery =
                from s in fruits
                where s.Substring(0, 1).ToUpper == "A"
                select s; 
            

            //Question 3
            List<string> months = new List<string>(12);
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            Console.WriteLine("Count = " + months.Count);
            Console.WriteLine("Capacity = " + months.Capacity);
            Console.Write('\n');

            for (int x = 0; x<=months.Count-1; x++)
                Console.WriteLine(months[x]);

            months.Insert(0, "January");
            months.Insert(1, "February");
            months.Insert(2, "March");
            months.Insert(3, "Arpil");
            months.Insert(4, "May");
            months.Insert(5, "June");
            Console.Write('\n');

            for (int x = 0; x <= months.Count - 1; x++)
                Console.WriteLine(months[x]);

            //Question 4
            Console.Write('\n');
            months.RemoveRange(0, 6);
            Console.WriteLine("Count = " + months.Count);
            Console.WriteLine("Capacity = " + months.Capacity);

            IEnumerable<string> monthquery =
                from s in months
                where s.Substring(s.Length-3, 3) == "ary"
                select s;

            foreach (string item in monthquery)
                Console.WriteLine(item);
        }
    }
}
