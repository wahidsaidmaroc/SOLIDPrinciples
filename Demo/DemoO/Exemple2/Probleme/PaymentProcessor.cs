namespace DemoO.Exemple2.Probleme;

internal class PaymentProcessor
{
    public void ProcessPayment(string paymentType)
    {

        if (paymentType == "CreditCard")
        {
            // Logique de paiement par carte de crédit
        }
        else if (paymentType == "PayPal")
        {
            // Logique de paiement par PayPal
        }
        else if (paymentType == "BankTransfer")
        {
            // Logique de paiement par virement bancaire
        }
        else
        {
            throw new ArgumentException("Type de paiement non supporté");
        }
    }
}
