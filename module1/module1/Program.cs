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
            Person p1 = new Person("siphax", "zerrouki", 27);
            Console.WriteLine($"The result of your class {p1.age}");
            Console.WriteLine($"Person objects created {Person.PersonCount}");

            Person p2 = new Person();
            Console.WriteLine(p2.age);
            Console.WriteLine($"Person objects created {Person.PersonCount}");

            Person p3 = new Person("sifaqes","zerrouki",27) ;
            p3.age = -5;
            Console.WriteLine($"Person objects created {Person.PersonCount}");

            Console.WriteLine(p3.ToString());




            Console.ReadLine();
        }
    }


    public class Person
    {
        //static members
        public static int PersonCount;


        //non-static members
        //instance variables
        private string Fname;
        private string Lname;
        private int Age;

        //proprietis

        //Constructors Inizialization Class
        static Person()
        {
            Console.WriteLine("static constructor ...");
            PersonCount = 0;
        }
        public Person(string Fname, string Lname, int Age) 
        {
            Console.WriteLine("custom constructer ..");
            PersonCount++;
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

        public override string ToString()
        {
            return $"The result of your class {Fname} {Lname} {Age}";
        }


       
    }
}
