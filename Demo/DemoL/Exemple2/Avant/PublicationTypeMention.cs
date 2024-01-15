using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL.Exemple2.Avant
{
    internal class PublicationTypeMention : Publication
    {
        public void CreationPublicationTypeMention(string text)
        {
            Console.WriteLine("Mention : " + text);
        }
    }
}
