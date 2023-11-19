using Lab4_Sophie_WF_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    [TestClass]
    public class EllipseTests
    {
        [TestMethod]
        public void Ellipse_IsCreated()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            Ellipse ellipse = new Ellipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis);
            Assert.AreEqual((radiusX, radiusY, center.X, center.Y, color, semiMajorAxis, semiMinorAxis),
                (ellipse.RadiusX, ellipse.RadiusY, ellipse.Center.X, ellipse.Center.Y, ellipse.Color, ellipse.SemiMajorAxis, ellipse.SemiMinorAxis));
        }

        [TestMethod]
        public void Ellipse_IsResizes()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            Ellipse ellipse = new Ellipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis);

            int newRadiusX = 5, newRadiusY = 5;

            ellipse.Resize(newRadiusX, newRadiusY);

            Assert.AreEqual((newRadiusX, newRadiusY),
                (ellipse.RadiusX, ellipse.RadiusY));
        }

        [TestMethod]
        public void Ellipse_IsRotating()
        {
            Point center = new Point(5, 3);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            Ellipse ellipse = new Ellipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis);

            int angle = 5;

            ellipse.Rotate(angle);

            Assert.AreEqual((4, 3), (center.X, center.Y));
        }

        [TestMethod]
        public void Ellipse_IsColorChanged()
        {
            Point center = new Point(5, 3);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            Ellipse ellipse = new Ellipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis);

            string newColor = "White";

            ellipse.ChangeColor(newColor);

            Assert.AreEqual(newColor, ellipse.Color);
        }
    }
}
