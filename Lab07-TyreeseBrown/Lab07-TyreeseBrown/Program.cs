using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_TyreeseBrown
{
    class MyMath
    {
        double result;
        double operand1;
        double operand2;
        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
        }
        public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }
        public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }
        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }
        public double GetResult()
        {
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            MyMath example = new MyMath();

            Console.WriteLine("Choose a number");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose another number to multiply it by");
            y = Convert.ToDouble(Console.ReadLine());
            example.Multiply(x, y);
            Console.WriteLine("The product is " + example.GetResult() + "\n");

            Console.WriteLine("Choose a number");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose another number to divide it by");
            y = Convert.ToDouble(Console.ReadLine());
            example.Divide(x, y);
            Console.WriteLine("The quotient is " + example.GetResult() + "\n");

            Console.WriteLine("Choose a number");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose another number to subract from it");
            y = Convert.ToDouble(Console.ReadLine());
            example.Subtract(x, y);
            Console.WriteLine("The difference is " + example.GetResult() + "\n");

            Console.WriteLine("Choose a number");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose another number to add to it");
            y = Convert.ToDouble(Console.ReadLine());
            example.Add(x, y);
            Console.WriteLine("The sum is " + example.GetResult() + "\n");
        }
    }
}