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
    public class ElipticalSectorTests
    {
        [TestMethod]
        public void ElipticalSector_IsCreated()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            float startAngle = 10f;
            float endAngle = 15f;

            EllipticalSector ellipticalSector = new EllipticalSector(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis, startAngle, endAngle);

            Assert.AreEqual((radiusX, radiusY, center.X, center.Y, color, semiMajorAxis, semiMinorAxis, startAngle, endAngle),
                (ellipticalSector.RadiusX, ellipticalSector.RadiusY, ellipticalSector.Center.X, ellipticalSector.Center.Y, 
                ellipticalSector.Color, ellipticalSector.SemiMajorAxis, ellipticalSector.SemiMinorAxis, ellipticalSector.StartAngle, ellipticalSector.EndAngle));
        }

        [TestMethod]
        public void ElipticalSector_IsRotated()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            float startAngle = 10f;
            float endAngle = 15f;

            EllipticalSector ellipticalSector = new EllipticalSector(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis, startAngle, endAngle);

            int angle = 15;

            ellipticalSector.Rotate(angle);

            double angleInRadians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            int newX = (int)(cosTheta * (center.X) - sinTheta * (center.Y));
            int newY = (int)(sinTheta * (center.X) + cosTheta * (center.Y));

            center.X = newX;
            center.Y = newY;

            int newStartX = (int)(cosTheta * (center.X + radiusX * Math.Cos(startAngle * Math.PI / 180.0))
                - sinTheta * (center.Y + radiusY * Math.Sin(startAngle * Math.PI / 180.0)));
            int newStartY = (int)(sinTheta * (center.X + radiusX * Math.Cos(startAngle * Math.PI / 180.0))
                + cosTheta * (center.Y + radiusY * Math.Sin(startAngle * Math.PI / 180.0)));

            int newEndX = (int)(cosTheta * (center.X + radiusX * Math.Cos(endAngle * Math.PI / 180.0))
                - sinTheta * (center.Y + radiusY * Math.Sin(endAngle * Math.PI / 180.0)));
            int newEndY = (int)(sinTheta * (center.X + radiusX * Math.Cos(endAngle * Math.PI / 180.0))
                + cosTheta * (center.Y + radiusY * Math.Sin(endAngle * Math.PI / 180.0)));

            Assert.AreEqual((newStartX, newStartY, newEndX, newEndY), (ellipticalSector.Start.X,
                ellipticalSector.Start.Y, ellipticalSector.End.X, ellipticalSector.End.Y));
        }
    }
}
