using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int get_x
        {
            get
            {
                return this.x;
            }
        }
        public int get_y
        {
            get
            {
                return this.y;
            }
        }
    }
    public class Figure  
    {
        private Point ob1;
        private Point ob2;
        private Point ob3;
        private Point ob4;
        private Point ob5;
        private string name;
        private int counter = 0;
        private double perimetr = 0;
        public double get_per
        {
            get
            {
                return perimetr;
            }
        }
        public string get_name
        {
            get
            {
                return name;
            }
        }

        public Figure(Point ob1, Point ob2, Point ob3)
        {
            this.ob1 = ob1;
            this.ob2 = ob2;
            this.ob3 = ob3;
            this.counter = 3;
            this.name = "triangle";
        }
        public Figure(Point ob1, Point ob2, Point ob3, Point ob4)
        {
            this.ob1 = ob1;
            this.ob2 = ob2;
            this.ob3 = ob3;
            this.ob4 = ob4;
            this.counter = 4;
            this.name = "square";
        }
        public Figure(Point ob1, Point ob2, Point ob3, Point ob4, Point ob5)
        {
            this.ob1 = ob1;
            this.ob2 = ob2;
            this.ob3 = ob3;
            this.ob4 = ob4;
            this.ob5 = ob5;
            this.counter = 5;
            this.name = "pentagon";
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.get_x - A.get_x, 2) + Math.Pow(B.get_y - A.get_y, 2));
        }
        public void PerimeterCalculator()
        {
            
            if(counter == 3)
            {
                perimetr = LengthSide(ob1, ob2) + LengthSide(ob2, ob3) + LengthSide(ob3, ob1);
            } else if(counter == 4)
            {
                perimetr = LengthSide(ob1, ob2) + LengthSide(ob2, ob3) + LengthSide(ob3, ob4) + LengthSide(ob4, ob1);
            } else if(counter == 5)
            {
                perimetr = LengthSide(ob1, ob2) + LengthSide(ob2, ob3) + LengthSide(ob3, ob4) +
                    LengthSide(ob4, ob5) + LengthSide(ob5, ob1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Point ob1 = new Point(0, 0);
            Point ob2 = new Point(1, 4);
            Point ob3 = new Point(2, 6);
            Point ob4 = new Point(3, -4);
            Point ob5 = new Point(1, -2);
            Figure fig_1 = new Figure(ob1, ob2, ob3, ob4, ob5);
            fig_1.PerimeterCalculator();
            Console.WriteLine($"Name: {fig_1.get_name} and perimetr: {Math.Round(fig_1.get_per,2)}");
            Console.ReadLine();
        }
    }
}
