namespace DemoD.Exemple2.Solution;

public class Notification
{
    
    private IMessage _message;
    //Injection With Constructor
    public Notification(IMessage message) { _message = message; }
    public void Envoyer() => _message.Envoyer();


}
