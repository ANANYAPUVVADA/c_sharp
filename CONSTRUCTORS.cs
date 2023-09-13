using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class courses
    {
        private string subject;
        private string student;
        private int grade;
        
        public courses(string subject, string student, int grade)  //constructor
        {
           this.subject = subject;
           this.student = student;
           this.grade = grade;
        }
         
        public void attendance(){
            Console.WriteLine(student + "present");
        }
    }
}

namespace constructors

{
    internal class Program
    {
        static void Main(string[] args)
        {
            courses c1 = new courses("math","zack",76);
            c1.attendance();
            courses c2 = new courses("science", "john", 06);
            c2.attendance();
            
        }
    }
}
