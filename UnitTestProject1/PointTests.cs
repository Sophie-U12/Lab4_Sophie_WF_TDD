using Lab4_Sophie_WF_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class PointTests
    {

        [TestMethod]
        public void Point_IsCreated()
        {
            Point point = new Point(1, 2);

            Assert.AreEqual((1, 2), (point.X, point.Y));
        }
        [TestMethod]
        public void Point_MoveCoordinatesIsChanged()
        {
            Point point = new Point(1, 2);

            point.Move(3, 4);

            Assert.AreEqual((4, 6), (point.X, point.Y));
        }
    }
}
