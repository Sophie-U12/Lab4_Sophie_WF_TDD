using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Sophie_WF_TDD
{
    public class EllipticalSector : Ellipse
    {
        public float StartAngle { get; set; }
        public float EndAngle { get; set; }
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public EllipticalSector() : base()
        {
            StartAngle = 0;
            EndAngle = 0;

            double startAngleInRadians = StartAngle * Math.PI / 180.0;
            double endAngleInRadians = EndAngle * Math.PI / 180.0;

            int startX = (int)(Center.X + RadiusX * Math.Cos(startAngleInRadians));
            int startY = (int)(Center.Y + RadiusY * Math.Sin(startAngleInRadians));

            int endX = (int)(Center.X + RadiusX * Math.Cos(endAngleInRadians));
            int endY = (int)(Center.Y + RadiusY * Math.Sin(endAngleInRadians));

            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }

        public EllipticalSector(int radiusX, int radiusY, Point center, string color, float semiMajorAxis, float semiMinorAxis, float startAngle, float endAngle) 
            : base(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis)
        {
            StartAngle = startAngle;
            EndAngle = endAngle;

            double startAngleInRadians = StartAngle * Math.PI / 180.0;
            double endAngleInRadians = EndAngle * Math.PI / 180.0;

            int startX = (int)(Center.X + RadiusX * Math.Cos(startAngleInRadians));
            int startY = (int)(Center.Y + RadiusY * Math.Sin(startAngleInRadians));

            int endX = (int)(Center.X + RadiusX * Math.Cos(endAngleInRadians));
            int endY = (int)(Center.Y + RadiusY * Math.Sin(endAngleInRadians));

            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }

        public override void Rotate(int angle)
        {
            double angleInRadians = angle * Math.PI / 180.0;
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);

            int newX = (int)(cosTheta * (Center.X) - sinTheta * (Center.Y));
            int newY = (int)(sinTheta * (Center.X) + cosTheta * (Center.Y));

            Center.X = newX;
            Center.Y = newY;

            int newStartX = (int)(cosTheta * (Center.X + RadiusX * Math.Cos(StartAngle * Math.PI / 180.0))
                - sinTheta * (Center.Y + RadiusY * Math.Sin(StartAngle * Math.PI / 180.0)));
            int newStartY = (int)(sinTheta * (Center.X + RadiusX * Math.Cos(StartAngle * Math.PI / 180.0))
                + cosTheta * (Center.Y + RadiusY * Math.Sin(StartAngle * Math.PI / 180.0)));

            int newEndX = (int)(cosTheta * (Center.X + RadiusX * Math.Cos(EndAngle * Math.PI / 180.0))
                - sinTheta * (Center.Y + RadiusY * Math.Sin(EndAngle * Math.PI / 180.0)));
            int newEndY = (int)(sinTheta * (Center.X + RadiusX * Math.Cos(EndAngle * Math.PI / 180.0))
                + cosTheta * (Center.Y + RadiusY * Math.Sin(EndAngle * Math.PI / 180.0)));

            Start.X = newStartX;
            Start.Y = newStartY;

            End.X = newEndX;
            End.Y = newEndY;
        }
    }
}
