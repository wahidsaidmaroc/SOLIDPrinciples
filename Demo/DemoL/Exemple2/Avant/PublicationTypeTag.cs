using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL.Exemple2.Avant
{
    internal class PublicationTypeTag : Publication
    {
        public  void CreationPublicationTypeTag(string text)
        {
            //save type tag
            Console.WriteLine("Tag : " + text);
        }
    }
}
