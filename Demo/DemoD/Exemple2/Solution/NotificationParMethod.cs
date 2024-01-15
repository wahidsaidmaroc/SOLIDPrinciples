using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple2.Solution
{
    public class NotificationParMethod
    {
        //C# Injection Par method
        public void Envoyer(IMessage message) => message.Envoyer();
    }
}
