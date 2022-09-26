using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_
{
    public class Quadratic
    {
        public int? X1 { get;  }
        public int? X2 { get; }

        public int? this[int index]
        {
            get
            {
                return index == 0 ? X1 : X2;
            }
        }
    }
}
