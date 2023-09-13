using System;
using System.Configuration;

namespace CLASSES
{   
    class Student                     //class
    {

        
        public string name;
        public int rollno;

        public void attendance()
        {  
            Console.WriteLine(name + " present " + rollno);
            
        }
    }
}

namespace CLASSES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();            //objects or instances
            s1.name = Console.ReadLine();
            s1.rollno = 03;
            s1.attendance();

            Student s2 = new Student();
            s2.name = "zack";
            s2.rollno = 004;
            Console.WriteLine(s1.name);
            Console.WriteLine(s2.name);

        }
    }
}
