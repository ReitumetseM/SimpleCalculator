using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Calculator
    {
        delegate int CalculatorDelegate(int x);
        public static int  addition(int x,int y)
        {
            return x + y;
        }
        public static int subtraction(int x, int y)
        {
            return x - y;
        }
        public static int multiplecation(int x, int y)
        {
            return x * y;
        }
        public static int division(int x, int y)
        {
            return x / y;
        }
        public static int modulus(int x, int y)
        {
            return x % y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x  value");
            int x =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y  value");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition");
            Console.WriteLine(addition(x, y));
            Console.WriteLine("Subtraction");
            Console.WriteLine(subtraction(x, y));
            Console.WriteLine("multiplication");
            Console.WriteLine(multiplecation(x, y));
            Console.WriteLine("Division");
            Console.WriteLine(division(x, y));
            Console.WriteLine("Modulus");
            Console.WriteLine(modulus(x, y));
        }
    }
}
