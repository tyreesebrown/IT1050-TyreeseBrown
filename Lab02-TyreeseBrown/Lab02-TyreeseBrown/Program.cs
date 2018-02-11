using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_TyreeseBrown
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2
            Console.WriteLine("Enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);

            
            //#3
            int x = 2;
            int y = 3;
            int z = 4;
            Console.WriteLine((x + y) * (z + 10));

            //#4
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");
        }
    }
}
