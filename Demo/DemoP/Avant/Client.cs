
namespace DemoP.Avant;
//nous avons une méthode de sauvegarde en base de données(persistance) et finalement une méthode
//qui déclenche un process métier.La classe a donc 3 raisons d'être modifiée : 

// On ajoute une nouvelle information au sujet des articles
// La sauvegarde en base de données doit être modifiée
// Le process métier d'envoi d'article doit être modifié



public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Adresse { get; set; } = string.Empty;
    public string Ville { get; set; } = string.Empty;
    void Ajouter()
    {
        //
    }
    void ClientToXML()
    {
        //
    }
    void EnvoyerMail()
    {
        //
    }
    void Modifier()
    {
        //
    }
    void Supprimer()
    {
        //
    }
    //D'autre methode

}
