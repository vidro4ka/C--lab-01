using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task_3;

namespace Test_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perimeter_Triangle()
        {
            Point ob1 = new Point(0, 0);
            Point ob2 = new Point(0, 3);
            Point ob3 = new Point(4, 0);

            Assert.AreEqual(ob1.get_x, 0);
            Assert.AreEqual(ob1.get_y, 0);

            Figure fig_test = new Figure(ob1, ob2, ob3);

            fig_test.PerimeterCalculator();

            Assert.AreEqual(fig_test.get_per, 12);
            Assert.AreEqual(fig_test.get_name, "triangle");
        }

        [TestMethod]
        public void Perimetr_Square()
        {
            Point ob1 = new Point(0, 0);
            Point ob2 = new Point(0, 4);
            Point ob3 = new Point(4, 4);
            Point ob4 = new Point(4, 0);

            Figure fig_test = new Figure(ob1, ob2, ob3, ob4);

            fig_test.PerimeterCalculator();

            Assert.AreEqual(fig_test.get_per, 16);
            Assert.AreEqual(fig_test.get_name, "square");
        }

        [TestMethod]
        public void Perimetr_Petiugol()
        {
            Point ob1 = new Point(0, 0);
            Point ob2 = new Point(1, 4);
            Point ob3 = new Point(2, 6);
            Point ob4 = new Point(3, -4);
            Point ob5 = new Point(1, -2);

            Figure fig_test = new Figure(ob1, ob2, ob3, ob4, ob5);

            fig_test.PerimeterCalculator();

            Assert.AreEqual(Math.Round(fig_test.get_per, 2), 21.47);
            Assert.AreEqual(fig_test.get_name, "pentagon");
        }

        [TestMethod]
        public void Zero_Coordinates()
        {
            Point ob1 = new Point(0, 0);
            Point ob2 = new Point(0, 0);
            Point ob3 = new Point(0, 0);
            Point ob4 = new Point(0, 0);
            Point ob5 = new Point(0, 0);

            Figure fig_test = new Figure(ob1, ob2, ob3, ob4, ob5);

            fig_test.PerimeterCalculator();

            Assert.AreEqual(fig_test.get_per, 0);
            Assert.AreEqual(fig_test.get_name, "pentagon");
        }
    }
}
