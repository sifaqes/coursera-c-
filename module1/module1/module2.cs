using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace modules
{
    internal class module2
    {
        static void Main(string[] args) 
        {
            //Vehicle v1 = new Vehicle();
            //Console.WriteLine(v1);
            //car c1 = new car("Mercides", "Benz", 2013);
            //Console.WriteLine(c1);
            //c1.OpenTrunck();
            //c1.Drive();
            //c1.Stop();


            Size S1 = new Size("Cube", 2, 2, 2, "m³");
            PrintArea(S1);

            Circle C1 = new Circle("Circle", 3, "m²");
            PrintArea(C1);

            Space SP1 = new Space("Space", 3, 2, "m²");
            PrintArea(SP1);

            Console.ReadLine();
        }
        public static void PrintArea(Shape p) 
        {
            Console.WriteLine($"The Shape of {p.Name} is {p.GetArea()} {p.GetUnity()}");
        }
    }
    // ---------------------------- Abserct class ----------------------------
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Unity { get; set; }
        public Shape(string Name, string Unity)
            {
                this.Name = Name;
                this.Unity = Unity;
            }

        

        public abstract Double GetArea();
        public abstract string GetUnity();

    }

    public class Size : Shape
    {
        private int Width;
        private int Height;
        private int Length;

        public Size(string Name, int Width, int Height, int Length, string Unity):base(Name,Unity)
        {
            this.Width = Width;
            this.Height = Height;
            this.Length = Length;
        }

        public override double GetArea()
        {
            return Width * Height * Length;
        }

        public override string GetUnity()
        {
            return Unity;
        }
    }

    public class Circle : Shape
    {
        private int Radius;
        public Circle(String Name, int Radius, string Unity):base(Name, Unity) 
        {
        this.Radius = Radius;
        }
        public override double GetArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public override string GetUnity()
        {
            return Unity;
        }
    }


    public class Space:Shape
    {
        private int Width;
        private int Height;

        public Space(string Name, int Width, int Height,string Unity) : base(Name, Unity)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override string GetUnity()
        {
            return Unity;
        }
    }





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
