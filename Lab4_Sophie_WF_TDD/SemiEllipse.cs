using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Sophie_WF_TDD
{
    public class SemiEllipse : Ellipse
    {
        public bool IsUpper { get; set; }
        public SemiEllipse() : base()
        {
            IsUpper = true;
        }
        public SemiEllipse(int radiusX, int radiusY, Point center, string color, float semiMajorAxis, float semiMinorAxis, bool isUpper) :
            base(radiusX, radiusY, center, color, semiMajorAxis, semiMinorAxis)
        {
            IsUpper = isUpper;
        }

        public virtual void Resize(float scale)
        {
            SemiMajorAxis *= scale;
            SemiMinorAxis *= scale;
        }
    }
}
