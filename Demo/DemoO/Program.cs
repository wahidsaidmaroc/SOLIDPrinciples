//Avant 


using DemoO.Apres;

var clientA = new DemoO.Avant.Client();
clientA.Solde = 10000;
Console.WriteLine(clientA.ToString() + clientA.CalculCredit("Class A"));


var clientB = new DemoO.Avant.Client();
clientB.Solde = 10000;
Console.WriteLine(clientB.ToString() + clientB.CalculCredit("Class B"));



//Apres : 
ClientA clientA1 = new ClientA();
clientA1.Solde = 10000;
Console.WriteLine(clientA1.ToString() + clientA1.CalculCredit());

ClientB ClientB1 = new ClientB();
ClientB1.Solde = 30000;
Console.WriteLine(ClientB1.ToString() + ClientB1.CalculCredit());
