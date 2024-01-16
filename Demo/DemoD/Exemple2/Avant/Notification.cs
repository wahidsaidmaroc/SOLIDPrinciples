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
        private MS365 _MS365 = new MS365();

        public void EnvoyerOutlook() => _Outlook.Envoyer();
        public void EnvoyerGMail() => _GMail.Envoyer();
        public void EnvoyerMS365() => _MS365.Envoyer();

    }
}
