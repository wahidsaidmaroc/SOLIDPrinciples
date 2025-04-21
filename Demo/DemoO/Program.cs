


#region "Demo O 1"




//Avant 

using DemoO.Exemple1.Apres;
using DemoO.Exemple2.Solution;
using static System.Net.Mime.MediaTypeNames;

var clientA = new DemoO.Exemple1.Avant.Client();
clientA.Solde = 10000;
//20000
Console.WriteLine(clientA.ToString() + clientA.CalculCredit("Class A"));


var clientB = new DemoO.Exemple1.Avant.Client();
clientB.Solde = 10000;
//30000
Console.WriteLine(clientB.ToString() + clientB.CalculCredit("Class B"));


//Apres : 
ClientA clientA1 = new DemoO.Exemple1.Apres.ClientA();
clientA1.Solde = 10000;
Console.WriteLine(clientA1.ToString() + clientA1.CalculCredit());

ClientB ClientB1 = new DemoO.Exemple1.Apres.ClientB();
ClientB1.Solde = 30000;
Console.WriteLine(ClientB1.ToString() + ClientB1.CalculCredit());


#endregion


#region "Demo O 2"

//Créez des instances de PaymentProcessor avec différents types de paiements et vérifiez que le traitement fonctionne correctement sans modifier la classe PaymentProcessor.
IPaymentMethod creditCardPayment = new CreditCardPayment();
PaymentProcessor processor = new PaymentProcessor(creditCardPayment);
processor.ProcessPayment();

IPaymentMethod payPalPayment = new PayPalPayment();
processor = new PaymentProcessor(payPalPayment);
processor.ProcessPayment();


#endregion