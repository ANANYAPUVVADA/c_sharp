using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        public static int squared(int x) {
            int res = x * x;
            return res;
        }

        public static Boolean isbigg(int x,int y)
        {
            bool ans=x>y;
            return ans;
        }
        static void Main(string[] args)
        {
            int temp=Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine(squared(temp));
            Console.WriteLine(isbigg(10,30));
        }
    }
}
