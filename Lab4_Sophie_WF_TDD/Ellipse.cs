using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Sophie_WF_TDD
{
    public class Ellipse
    {
        public int RadiusX { get; set; }
        public int RadiusY { get; set; }
        public Point Center { get; set; }
        public string Color { get; set; }
        public float SemiMajorAxis { get; set; }
        public float SemiMinorAxis { get; set; }

        public Ellipse()
        {
            RadiusX = 0;
            RadiusY = 0;
            SemiMajorAxis = 0;
            SemiMinorAxis = 0;
            Color = "#000000";
            Center = new Point(0, 0);
        }
        public Ellipse(int radiusX, int radiusY, Point center, string color, float semiMajorAxis, float semiMinorAxis)
        {
            RadiusX = radiusX;
            RadiusY = radiusY;
            Center = center;
            Color = color;
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        public void Resize(int newRadiusX, int newRadiusY)
        {
            RadiusX = newRadiusX;
            RadiusY = newRadiusY;
        }

        public virtual void Rotate(int angle)
        {
            double angleInRadians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            int newX = (int)(cosTheta * (Center.X) - sinTheta * (Center.Y));
            int newY = (int)(sinTheta * (Center.X) + cosTheta * (Center.Y));

            Center.X = newX;
            Center.Y = newY;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
