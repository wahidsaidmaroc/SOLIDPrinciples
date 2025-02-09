using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL.Exemple4.Solution
{
    public abstract class ObjetSaid
    {
        public int L { get; set; }
        public int H { get; set; }

        public abstract int CalculSup();
    }
}
