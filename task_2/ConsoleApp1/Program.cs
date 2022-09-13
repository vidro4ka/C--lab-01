using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    public class Rectangle
    {
        private double side1 = 0;
        private double side2 = 0;
        public Rectangle()
        {
            side1 = 0;
            side2 = 0;
        }
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA;
            side2 = sideB;
        }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            Rectangle object_1 = new Rectangle(sideA, sideB);
            Console.WriteLine("Area: {0} and Perimetr: {1}", object_1.Area, object_1.Perimeter);
            Console.ReadLine();
        }
    }
}
