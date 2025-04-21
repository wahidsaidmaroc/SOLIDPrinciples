using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoO.Exemple1.ApresInterface
{
    internal class ClientA : IClient
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Solde { get; set; }
        public double CalculCredit()
        {
            return 10000 + Solde;
        }
    }
}
