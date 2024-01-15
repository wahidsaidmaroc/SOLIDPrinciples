using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoO.Avant
{
    internal class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Solde { get; set; }
        public double CalculCredit(string typeClient)
        {
            if (typeClient == "Class A")
            {
                return 10000 + Solde;
            }
            if (typeClient == "Class B")
            {
                return 20000 + Solde;
            }

            return 0;
        }

        public override string ToString() 
        {
            return $"Client : {Nom} , Credit : ";
        }
    }
}
