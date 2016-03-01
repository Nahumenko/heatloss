using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
    class linterp
    {
        public double x0;
        public double x1;
        public double x2;
        public double y0;
        public double y1;
        public double y2;

        public double lint(double x0, double x1, double x2, double y0, double y1, double y2)

        {
            if (x0 < x1 && x1 < x2)
            {
                if (y0 == 0) { return y0 = (y1 * (x0 - x2) + y2 * (x1 - x0)) / (x1 - x2); }
                if (y1 == 0) { return y1 = y0 + (x1 - x0) / (x2 - x0) * (y2 - y0); }
                if (y2 == 0) { return y2 = y0 + (y1 - y0) * (x2 - x0) / (x1 - x0); }
                else { return 666999; }
            }
            else
            {
                return 666999;
            }
        }
    }
}
