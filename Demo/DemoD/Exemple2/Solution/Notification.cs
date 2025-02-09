namespace DemoD.Exemple2.Solution;

public class Notification
{
    
    private IMessage _serveur;
    //Injection With Constructor
    public Notification(IMessage serveur)
    { _serveur = serveur; }
    public void Envoyer() => _serveur.Envoyer();


}
