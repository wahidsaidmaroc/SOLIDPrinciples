


//Exemple 2 : 


var notification = new DemoD.Exemple2.Avant.Notification();


notification.EnvoyerGMail();
notification.EnvoyerOutlook();
notification.EnvoyerJobInTechSMTP();
//Supposons on veux ajouter un  autre type notification webmail ....Hotmail.....


//Solution  1 
//Injection With Constructor
var notificationS = new DemoD.Exemple2.Solution.Notification(new DemoD.Exemple2.Solution.GMail());
notificationS.Envoyer();


//Injection With Method
var notificationWithMethod = new DemoD.Exemple2.Solution.NotificationParMethod();
notificationWithMethod.Envoyer(new DemoD.Exemple2.Solution.GMail());


//Property injection
var notificationWithProperty = new DemoD.Exemple2.Solution.NotificationWithPropertyInjection();
notificationWithProperty.MessageType = new DemoD.Exemple2.Solution.GMail();
notificationWithProperty.Envoyer();

