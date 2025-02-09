
namespace DemoS.Apres;


//La classe Client de base qui reste le DTO(Data Transfert Object), 


public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Adresse { get; set; } = string.Empty;
    public string Ville { get; set; } = string.Empty;
}
