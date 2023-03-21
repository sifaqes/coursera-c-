﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Person.PrintPersonCount();

            Person p2 = new Person();
            Console.WriteLine(p2.age);
            Person.PrintPersonCount();

            Person p3 = new Person("sifaqes","zerrouki",27) ;
            p3.age = -5;
            Person.PrintPersonCount();

            Console.WriteLine(p3.ToString());




            Console.ReadLine();
        }
    }


    public class Person
    {
        //1-members (Variable)
            //Static members
            public static int PersonCount;

            //Non static members    
            private string Fname;
            private string Lname;
            private int Age;

        //2-Constructors
            //static Constructors
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
            public Person() : this("Empty", "Empty", 0)
            {
            }
        //Non static Constructors






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



        //Methodes
            //static methodes
            public static void PrintPersonCount()
            {
            Console.WriteLine($"Person Objects created {PersonCount}");
            }

            //Non static methodes
            public override string ToString()
            {
                return $"The result of your class {Fname} {Lname} {Age}";
            }


    }
}
