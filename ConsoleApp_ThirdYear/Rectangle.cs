using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ThirdYear
{
    class Rectangle : Shape
    {
        private double _side1;
        private double _side2;
        
        public double Side1
        {
            get
            {
                return _side1;
            }
            set
            {
                _side1 = value;
                _perimeter = 2 * (Side1 + Side2);
                _area = Side1 * Side2;
            }
        }
        public double Side2
        {
            get
            {
                return _side2;
            }
            set
            {
                _side2 = value;
                _perimeter = 2 * (Side1 + Side2);
                _area = Side1 * Side2;
            }
        }
        

        public Rectangle() : base()
        {
            Console.WriteLine("Rectangle is created");
        }

        public Rectangle(double Side1, double Side2)
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            //_perimeter = 2 * (Side1 + Side2);
            //_area = Side1 * Side2;
        }

        public void Print()
        {
            Console.WriteLine($"Side1 = {Side1}, Side2 = {Side2},");
            Console.WriteLine($"Area = {Area}, Perimeter = {Perimeter}.\n");
        }
    }
}
