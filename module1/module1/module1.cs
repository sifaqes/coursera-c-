using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    internal class module1
    {
        //static void Main(string[] args)
        //{
        //    //Person p1 = new Person("siphax", "zerrouki", 27);
        //    //Console.WriteLine($"The result of your class {p1.age}");
        //    //Person.PrintPersonCount();

        //    //Person p2 = new Person();
        //    //Console.WriteLine(p2.age);
        //    //Person.PrintPersonCount();

        //    //Person p3 = new Person("sifaqes", "zerrouki", 27);
        //    //p3.age = -5;
        //    //Person.PrintPersonCount();

        //    //Console.WriteLine(p3.ToString());

        //    ////call by value 
        //    //int a = 2;
        //    //int b = 10;
        //    //Console.WriteLine($"1. a={a} and b = {b}");

        //    //M1(ref a, out b);
        //    //Console.WriteLine($"2. a={a} and b = {b}");


        //    //selection structure 
        //    //Signle selection statment
        //    if (Person.PersonCount >= 0)
        //    {
        //        Console.WriteLine($"Passed {Person.PersonCount}");
        //    }

        //    //Double selection statment
        //    if (Person.PersonCount >= 0)
        //    {
        //        Console.WriteLine($"Signle selection statment Passed {Person.PersonCount}");
        //    } else
        //    {
        //        Console.WriteLine($"Signle selection statment Failed {Person.PersonCount}");
        //    }

        //    //Double selection statment Tirnary operation
        //    string result = Person.PersonCount >= 1 ? $"Passed {Person.PersonCount}": $"Failed {Person.PersonCount}";
        //    Console.WriteLine($"Signle selection statment {result}");

        //    //Nested IF 
        //    if (Person.PersonCount >= 0) 
        //    {
        //        Console.WriteLine($"Nested IF {Person.PersonCount}");
        //    }
        //    else if (Person.PersonCount > 0)
        //    {
        //        Console.WriteLine($"Nested IF {Person.PersonCount}");
        //    }
        //    else if(Person.PersonCount == 0) 
        //    {
        //        Console.WriteLine($"Nested IF {Person.PersonCount}");
        //    }

        //    //case
        //    int z = 1;



        //    switch(z)
        //    {
        //        case 1:
        //            Console.WriteLine("z = 1");
        //            break;
        //        case 2:
        //            Console.WriteLine("z = 2");
        //            break;
        //        case 3:
        //            Console.WriteLine("z = 3");
        //            break;
        //        case 4:
        //            Console.WriteLine("z = 4");
        //            break;
        //        case 5:
        //            Console.WriteLine("z = 5");
        //            break;
        //        default:
        //            Console.WriteLine($"Z = {z}");
        //            break;
        //    }


        //    //Repetition statment while for do while
        //    for (int x = 0; x <= 10; x++)
        //    {
        //        Console.WriteLine($"For Repetition statment is {x}");
        //    }

        //    for (int y = 10; y >= 0; y--)
        //    {
        //        Console.WriteLine($"For Repetition statment is {y}");
        //    }

        //    int i = 0;
        //    while (i < 5)
        //    {
        //        Console.WriteLine($"i={i}");
        //        i++;
        //    }
        //    i = 4;
        //    do
        //    {
        //        Console.WriteLine($"do i={i}");
        //        i++;
        //    } while (i < 5);
        //    for (int R = 1; R < 4; R++)
        //    {
        //        for (int C = 0; C < R; C++)
        //        {
        //            Console.Write($"*");
        //        }
        //        Console.Write(" ");
        //    }
        //    int A = 1;
        //    int B = 1;
        //    do
        //    {
        //        B *= A;
        //        A++;
        //    } while (A < 4);
        //    Console.WriteLine(B);

        //    Console.ReadLine();
        //}
        public static void M1(ref int x, out int y)
        {
            //Console.WriteLine($"3. a={x} and b = {y}");
            x = x * 2;
            y= 200;
            Console.WriteLine($"4. a={x} and b = {y}");
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
