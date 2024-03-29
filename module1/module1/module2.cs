﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace modules
{

    public class Animal 
    {
        private string Name;
        public Animal(string Name )
        {
            this.Name = Name;
        }
        public virtual void Move() 
        {
            string Loc = CurrLoc();
            Console.WriteLine($"{Name} is moving startinc from {Loc}");
        }
        public virtual string CurrLoc()
        {
            return "[Animal Loc]";
        }
    }

    public class Fish : Animal
    {
        public Fish(String Name) : base(Name) 
        { 

        }
    }
    public class Frog : Animal
    {
        public Frog(String Name) : base(Name)
        {

        }
    }
    public class Bird : Animal
    {
        public Bird(String Name) : base(Name)
        {

        }
    }
    internal class module2
    {
        public static void M1(Animal[] Animals)
        {
            foreach(Animal A in Animals)
            {
                A.Move();
            }
        }
        static void Main(string[] args)
        {

            Animal A1 = new Animal("Animal");
            Animal A2 = new Fish("Fish");
            Animal A3 = new Frog("Frog");
            Animal A4 = new Bird("Bird");
            Animal[] animals = {A1, A2 , A3 , A4 };
            M1(animals);
            Console.ReadLine();

            //Vehicle v1 = new Vehicle();
            //Console.WriteLine(v1);
            //car c1 = new car("Mercides", "Benz", 2013);
            //Console.WriteLine(c1);
            //c1.OpenTrunck();
            //c1.Drive();
            //c1.Stop();

            //Size S1 = new Size("Cube", 2, 2, 2, "m³");
            //PrintArea(S1);
            //Circle C1 = new Circle("Circle", 3, "m²");
            //PrintArea(C1);
            //Space SP1 = new Space("Space", 3, 2, "m²");
            //PrintArea(SP1);


            //Numbers N = new Numbers();
            //N.AddNumbers(1);
            //N.AddNumbers(2);
            //N.AddNumbers(3);
            //N.AddNumbers(4);
            //PrintCount(N);

            //Persones P = new Persones();
            //P.AddPersons("Siphax");
            //P.AddPersons("Youva");
            //PrintCount(P);
            //PrintPersons(P);

            //Console.ReadLine();
        }
        //public static void PrintCount(ICountable I)
        //{
        //    Console.WriteLine($"There are {I.Counts()} memebers on this object.");
        //}

        //public static void PrintPersons(ICountable P)
        //{
        //    Console.WriteLine($"There members Nams is {P.GetPersones()}.");
        //}

        //public static void PrintArea(Shape p) 
        //{
        //    Console.WriteLine($"The Shape of {p.Name} is {p.GetArea()} {p.GetUnity()}");
        //}
    }


    //public interface ICountable
    //{
    //    public int Counts();
    //    public string GetPersones();
    //}

    //public class Numbers: ICountable
    //{
    //    private List<int> MyNumbers;
    //    public Numbers()
    //    {
    //        this.MyNumbers = new List<int>();
    //    }



    //    public void AddNumbers(int N)
    //    {
    //        MyNumbers.Add(N);
    //    }
    //    public int Counts()
    //    {
    //        return this.MyNumbers.Count();
    //    }

    //    public string GetPersones()
    //    {
    //        return "list";
    //    }
    //}

    //public class Persones : ICountable
    //{
    //    private List<string> MyPersons;

    //    public Persones()
    //    { 
    //    this.MyPersons = new List<string>();
    //    }


    //    public void AddPersons(string Name) 
    //    {
    //        MyPersons.Add(Name);
    //    }

    //    public int Counts()
    //    {
    //        return 0;
    //    }

    //    public string GetPersones()
    //    {
    //        string lista = "";
    //        foreach (string result in MyPersons)
    //        {
    //            lista += result + " ";
    //        }
    //        return lista;
    //    }
    //}






























    //// ---------------------------- Abserct class ----------------------------
    //public abstract class Shape
    //{
    //    public string Name { get; set; }
    //    public string Unity { get; set; }
    //    public Shape(string Name, string Unity)
    //        {
    //            this.Name = Name;
    //            this.Unity = Unity;
    //        }

    //    public abstract Double GetArea();
    //    public abstract string GetUnity();

    //}

    //public class Size : Shape
    //{
    //    private int Width;
    //    private int Height;
    //    private int Length;

    //    public Size(string Name, int Width, int Height, int Length, string Unity):base(Name,Unity)
    //    {
    //        this.Width = Width;
    //        this.Height = Height;
    //        this.Length = Length;
    //    }

    //    public override double GetArea()
    //    {
    //        return Width * Height * Length;
    //    }

    //    public override string GetUnity()
    //    {
    //        return Unity;
    //    }
    //}

    //public class Circle : Shape
    //{
    //    private int Radius;
    //    public Circle(String Name, int Radius, string Unity):base(Name, Unity) 
    //    {
    //    this.Radius = Radius;
    //    }
    //    public override double GetArea()
    //    {
    //        return this.Radius * this.Radius * Math.PI;
    //    }

    //    public override string GetUnity()
    //    {
    //        return Unity;
    //    }
    //}


    //public class Space:Shape
    //{
    //    private int Width;
    //    private int Height;

    //    public Space(string Name, int Width, int Height,string Unity) : base(Name, Unity)
    //    {
    //        this.Width = Width;
    //        this.Height = Height;
    //    }
    //    public override double GetArea()
    //    {
    //        return Width * Height;
    //    }

    //    public override string GetUnity()
    //    {
    //        return Unity;
    //    }
    //}





    //// -------------------------------------- Inheritance --------------------------------------
    //public class Vehicle
    //{
    //    private string Make;
    //    private string Model;
    //    private int Year;
    //    //set constructor
    //    public Vehicle(string Make, string Model, int Year)
    //    {
    //        this.Make = Make;
    //        this.Model = Model;
    //        this.Year = Year;
    //    }

    //    //set constructor emply
    //    public Vehicle() : this("Empty", "Empty", 0) 
    //    {

    //    }

    //    //override: change the default behavior of the method
    //    public override string ToString()
    //    {
    //        return $"{Year} {Make} {Model}";
    //    }
    //    //set a virtual method
    //    // whith a virtual method you can override it in another class
    //    public virtual void Drive()
    //    {
    //        Console.WriteLine("Vehicle is driving...");
    //    }

    //    public virtual void Stop()
    //    {
    //        Console.WriteLine("Vehicle is stopping...");
    //    }
    //}

    //public class car : Vehicle 
    //{
    //    public car(string Make, string Model, int Year):base(Make, Model, Year) 
    //    {

    //    }

    //    public void OpenTrunck() 
    //    {
    //    Console.WriteLine("Opening the trunck...");
    //    }

    //    public override void Drive()
    //    {
    //        Console.WriteLine("Car is driving...");
    //    }

    //    //seales: don't make override a another driving class
    //    public sealed override void Stop()
    //    {
    //        Console.WriteLine("The car is stopping...");
    //    }
    //}





    //// --------------------------------- Encapsulation class ------------------------------------------------
    //public class Student
    //{
    //    private int _Id;
    //    private string _Name;

    //    public Student(int Id, string Name)
    //    {
    //        if (_Id < 0) 
    //        {
    //        _Id = 0;
    //        }else
    //        {
    //            _Id = Id;
    //            _Name = Name;
    //        }

    //    }

    //    public int Id
    //    {
    //        get { return _Id; }
    //        set
    //        {
    //                if (value < 0)
    //            {
    //                    _Id = 0;
    //                Console.WriteLine($"ID={_Id} cannot be less than zero.");
    //                }
    //                else
    //            {
    //                    _Id = value;
    //                }
    //            }
    //    }

    //    public string Name { get; set; } 
    //    public void Talk()
    //    {

    //    }
    //}
}
