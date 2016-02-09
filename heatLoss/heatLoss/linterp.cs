using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heatLoss
{
    class linterp
    {
        double x0;
        double x1;
        double x2;
        double y0;
        double y1;
        double y2;

        public double lint(double x0, double x1, double x2, double y0, double y1, double y2, int sought)
        {
            if (x0 < x1 && x1 < x2)
            {
                switch (sought) // счетчик какую переменную считать
                {
                    case 0:
                        return y0 = (y1 * ((x2 - x0) / (x1 - x0)) - y2) / (((x2 - x0) / (x1 - x0)) + 1); 
                        break;
                    case 1:
                        return y1 = y0 + (x1 - x0) / (x2 - x0) * (y2 - y0);
                        break;
                    case 2:
                        return y2 = y0 + (y1 - y0) * (x2 - x0) / (x1 - x0);

                    default:
                        return 666999123.0;
                        break;
                }
            }
            else
            {
                return 666999123;
            }
        }
    }
}
