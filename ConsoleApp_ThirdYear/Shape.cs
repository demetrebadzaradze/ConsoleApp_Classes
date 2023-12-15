using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ThirdYear
{
    // 2D math shapes
    class Shape
    {
        protected double _perimeter;
        protected double _area;

        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }
        public double Area
        {
            get
            {
                return _area;
            }
        }

        public Shape()
        {
            Console.WriteLine("Shape is created");
        }
    }
}
