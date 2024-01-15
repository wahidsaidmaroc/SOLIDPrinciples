using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoI.Exemple1.Avant
{
    public class Car
    {
        public void Run() => Console.Write("Running");
        public void Fly() => throw new NotImplementedException();
    }
}
