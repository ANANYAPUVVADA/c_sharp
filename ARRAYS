using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Benz", "Audi", "Swift" };
            int[] nums = { 2, 5, 6, 7, 8 };
            cars[3] = "RR";
            Console.WriteLine(cars[2]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums.Length);

            //ARRAY LOOPING

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine(nums[i] + 10);
            }


            for (int j = 0; j < cars.Length; j++) {
                Console.WriteLine(cars[j]);

            }


            //SORT 

            Array.Sort(nums);

            foreach (int i in nums)
            {
                Console.Write(i);
                Console.WriteLine();

            }

            //2D ARRAYS
            int[,] rollno = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.Write(rollno[1, 1]);
            int[,,] bikes = { { { 10, 20, 30 }, { 40, 50, 60 } }, { { 70, 80, 90 }, { 100, 110, 120 } } };
            Console.WriteLine(bikes[0,1,0]);
            foreach(int i in rollno) { 
                Console.WriteLine(i);
            }
            

        }

        

    }   


    
}
