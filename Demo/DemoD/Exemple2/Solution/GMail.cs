using DemoD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple2.Solution
{
    internal class GMail : IMessage
    {
        public string Adresse { get; set; }
        public string De { get; set; }
        public string Destinataire { get; set; }
        public void Envoyer()
        { 
        }
            
    }
}
