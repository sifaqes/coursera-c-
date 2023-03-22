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
            int x = 10;
            Console.WriteLine($"x={x}");
            Console.ReadLine();
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
