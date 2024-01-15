using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple2.Avant
{
    public class Notification
    {
        private GMail _GMail = new GMail();
        private Outlook _Outlook = new Outlook();

        public void EnvoyerOutlook() => _Outlook.Envoyer();
        public void EnvoyerGMail() => _GMail.Envoyer();


    }
}
