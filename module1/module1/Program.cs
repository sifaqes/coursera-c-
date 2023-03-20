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

            //Person p2 = new Person();
            //Console.WriteLine(p2.age);

            Person p3 = new Person("sifaqes","zerrouki",27) ;
            p3.age = -5;


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

        public int age
        {
            get
            {
                return Age;
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine($"The age most be less a 0");
                }
                else
                {
                    Age = value;
                    Console.WriteLine($"The result of your age is {Age}");
                }
                

            }
        }

       
    }
}
