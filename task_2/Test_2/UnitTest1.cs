using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task_2;

namespace Test_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double sideA = 8;
            double sideB = 5;

            Rectangle object_test = new Rectangle(sideA, sideB);

            Assert.AreEqual(object_test.Area, 40);
            Assert.AreEqual(object_test.Perimeter, 26);
        }
    }
}
