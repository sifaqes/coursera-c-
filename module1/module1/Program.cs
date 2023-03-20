using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("siphax", "zerrouki",27) ;
            //Console.WriteLine($"The result of your class {p1.sayAll}");

            Person p2 = new Person();
            Console.WriteLine(p2.sayAll);
            Console.ReadLine();
        }
    }


    public class Person
    {
        private string Fname;
        private string Lname;
        private int Age;

        //proprietis

        //Constructor
        public Person(string Fname, string Lname, int Age) 
        {
            this.Lname = Lname;
            this.Fname = Fname;
            this.Age = Age;
        }

        public Person():this("Empty","Empty",0)
        {
        }

        public string sayAll
        {
            get
            {
                return $"P2: {Fname}, {Lname}, {Age}";
            }
            set 
            {
                Fname= value;
                Lname = value;
                if (int.Parse(value) < 0)
                {
                    Console.WriteLine($"The age most be less a 0");
                }
                else
                {
                    Age = int.Parse(value);
                }
                

            }
        }

       
    }
}
