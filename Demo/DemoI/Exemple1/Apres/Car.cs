using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoI.Exemple1.Apres
{
    internal class Car : IRunnable
    {
        public void Run() => Console.Write("Running");

    }
}
