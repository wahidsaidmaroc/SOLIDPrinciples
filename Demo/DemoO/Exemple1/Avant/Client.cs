using System.Net.Http.Headers;

namespace DemoO.Exemple1.Avant;

internal class Client
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public double Solde { get; set; }
    public double CalculCredit(string typeClient)
    {
        if (typeClient == "Class A")
        {
            return 10000 + Solde;
        }
        if (typeClient == "Class B")
        {
            return 20000 + Solde;
        }
        if (typeClient == "Class C")
        {
            return 20300 + Solde;
        }

        return 0;
    }
    public override string ToString()
    {
        return $"Client : {Nom} , Credit : ";
    }
}
