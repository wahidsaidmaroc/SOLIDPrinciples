using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL.Exemple4.Probleme
{
    public abstract class ObjetSaid
    {
        public int L { get; set; }
        public int H { get; set; }

        public int CalculSup()
        { return L * H; }
    }
}
