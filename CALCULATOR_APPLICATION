using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR_APPLICATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                
                Console.Write("Enter first number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the required symbols(+,-,*,/,%)");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "+":
                        Console.WriteLine(x + y);
                        break;
                    case "-":
                        Console.WriteLine(x - y);
                        break;
                    case "*":
                        Console.WriteLine(x * y);
                        break;
                    case "/":
                        Console.WriteLine(x / y);
                        break;
                    case "%":
                        Console.WriteLine(x % y);
                        break;
                    default:
                        Console.WriteLine("cannot be determined");
                        break;
                }
                
                Console.WriteLine("do you want to continue click (y/n)");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");

        }
    }
}
