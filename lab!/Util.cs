using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_
{
    public static class Util
    {
        public static double? sqrt(double x, out int errorCode)
        {
            errorCode = -1;
            if (x >= 0)
            {
                errorCode = 0;
                if(x == 0) { return x; }
                double root = x / 2;

                for (int i = 0; i < 100; i++) 
                {
                    root = (root + x / root) / 2d; 
                }
                return root;
            }
            return null;
        }
    }
}
