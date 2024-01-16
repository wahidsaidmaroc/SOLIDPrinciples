using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL.Exemple2.Avant
{
    public class Publication
    {
        public virtual void Creation(string text)
        {
            //Save to Commentaire
            Console.WriteLine("Commentaire : " + text);
        }


    }
}
