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

            Vehicle v1 = new Vehicle();
            Console.WriteLine(v1);

            car c1 = new car("Mercides", "Benz", 2013);
            Console.WriteLine(c1);
            c1.OpenTrunck();
            c1.Drive();
            c1.Stop();

            Console.ReadLine();
        }
    }

    public class Vehicle
    {
        private string Make;
        private string Model;
        private int Year;
        //set constructor
        public Vehicle(string Make, string Model, int Year)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
        }

        //set constructor emply
        public Vehicle() : this("Empty", "Empty", 0) 
        {
        }

        //override: change the default behavior of the method
        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }
        //set a virtual method
        // whith a virtual method you can override it in another class
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }
    }

    public class car : Vehicle 
    {
        public car(string Make, string Model, int Year):base(Make, Model, Year) 
        {
        
        }

        public void OpenTrunck() 
        {
        Console.WriteLine("Opening the trunck...");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is driving...");
        }

        //seales: don't make override a another driving class
        public sealed override void Stop()
        {
            Console.WriteLine("The car is stopping...");
        }
    }




















    public class Student
    {
        private int _Id;
        private string _Name;

        public Student(int Id, string Name)
        {
            if (_Id < 0) 
            {
            _Id = 0;
            }else
            {
                _Id = Id;
                _Name = Name;
            }

        }

        public int Id
        {
            get { return _Id; }
            set
            {
                    if (value < 0)
                {
                        _Id = 0;
                    Console.WriteLine($"ID={_Id} cannot be less than zero.");
                    }
                    else
                {
                        _Id = value;
                    }
                }
        }

        public string Name { get; set; } 
        public void Talk()
        {

        }
    }
}
