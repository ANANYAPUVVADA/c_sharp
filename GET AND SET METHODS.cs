using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_ans_set_methods
{
    class employee

    {
        private int id;
        private string name;
        private int age;
        private int grade;
        private string reward;
        public employee(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public string getname()
        {
            if (age <= 50)
            {
                return name;
            }
            else
            {
                return "senior employee";
            }
        }

        public int getid()     //get method
        {
            return id;
        }
        public int getgrade()
        {
            return grade;
        }
        public void setgrade(int finalgrade)   //set method
        {
            
            if(grade<50)
            {
                finalgrade= 65;
            }
            else
            {
                finalgrade = 90;
            }
            grade = finalgrade;
        }
        public string getreward()
        {
            return reward;
        }
        public void setreward(string topreward)
        {
            reward = topreward;

        }
      
    }
    internal class Program
    {
      static void Main(string[] args)
      {
        employee e1 = new employee("tom",83,75);
        e1.getname();
        Console.WriteLine(e1.getname());
        e1.getid();
        Console.WriteLine(e1.getid());
        e1.setgrade(45);
        Console.WriteLine(e1.getgrade());
        e1.setreward("A");
        Console.WriteLine(e1.getreward());
      }
    }
}
