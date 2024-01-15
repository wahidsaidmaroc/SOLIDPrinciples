using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple2.Solution
{
    internal class NotificationWithPropertyInjection
    {
        public IMessage MessageType { get; set; }
        public void Envoyer() => MessageType.Envoyer();

    }
}
