using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    public class Cilindr
    {
         public  double h;
        public double r;

        public  Cilindr()
        {
         h = 1;
            r = 1;
        }

        public Cilindr(double hh, double rr)
        {
            h = hh;
            r = rr; 
        }

        public  double Square()
        {
            return 2 * r * h * 3.14;
        }

        public  double VVV()
        {
            return r * r * h * 3.14;
        }
    }
}
