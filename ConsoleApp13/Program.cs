using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
   
    class Person
    {
        public string name;
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Incorrect age");
                else
                    age = value;
            }
        }
        public void Info()
        {
            Console.WriteLine($"Name: {name}\nAge:{age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person anvar = new Person();
            anvar.name = "Anvar";
            anvar.Age = -19;
            anvar.Info();
            Console.ReadLine();
        }
    }
}
