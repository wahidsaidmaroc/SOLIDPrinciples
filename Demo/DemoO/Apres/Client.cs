using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoO.Apres
{
    internal abstract class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public double Solde { get; set; }
        public abstract double CalculCredit();
        public override string ToString()
        {
            return $"Client : {Nom} , Credit : ";
        }
    }
}
