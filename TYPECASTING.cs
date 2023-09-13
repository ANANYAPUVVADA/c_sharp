using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            double y = 10.8;
            bool s = true;
            Console.WriteLine(Convert.ToDouble(x));
            Console.WriteLine(Convert.ToInt32(y));
            Console.WriteLine(Convert.ToString(s));
        }
    }
}
