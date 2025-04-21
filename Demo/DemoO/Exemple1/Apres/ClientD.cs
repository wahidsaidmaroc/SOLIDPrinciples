using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoO.Exemple1.Apres
{
    internal class ClientD : Client
    {
        public override double CalculCredit()
        {
            return 100100 + Solde;
        }
    }
}
