using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Logical operators

            int x = 5, y = 10;
            Console.WriteLine( x < 7 && y > 10);
            Console.WriteLine(x < 5 || y > 10);

            //Assignment operators

            x += 10;
            y -= 5;
            x *= 6;
            y /= 5;
        }
    }
}
