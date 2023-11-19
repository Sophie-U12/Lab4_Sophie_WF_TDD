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
    public class SemiEllipseTests
    {
        [TestMethod]
        public void SemiEllipse_IsCreated()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            bool isUpper = true;

            SemiEllipse semiEllipse = new SemiEllipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis, isUpper);
            Assert.AreEqual((radiusX, radiusY, center.X, center.Y, color, semiMajorAxis, semiMinorAxis, isUpper),
                (semiEllipse.RadiusX, semiEllipse.RadiusY, semiEllipse.Center.X, semiEllipse.Center.Y, semiEllipse.Color,
                semiEllipse.SemiMajorAxis, semiEllipse.SemiMinorAxis, semiEllipse.IsUpper));
        }

        [TestMethod]
        public void SemiEllipse_IsResized()
        {
            Point center = new Point(0, 0);
            int radiusX = 10;
            int radiusY = 10;
            string color = "Black";

            float semiMajorAxis = 5f;
            float semiMinorAxis = 5f;

            bool isUpper = true;

            SemiEllipse semiEllipse = new SemiEllipse(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis, isUpper);

            float scale = 5f;

            semiEllipse.Resize(scale);

            Assert.AreEqual((semiMajorAxis * scale, semiMinorAxis * scale), (semiEllipse.SemiMajorAxis, semiEllipse.SemiMinorAxis));
        }
    }
}
