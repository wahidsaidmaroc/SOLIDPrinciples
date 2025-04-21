namespace DemoO.Exemple2.Solution;


//Créez une interface IPaymentMethod avec une méthode ProcessPayment.
public interface IPaymentMethod
{
    void ProcessPayment();
}

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        // Logique de paiement par carte de crédit
    }
}

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        // Logique de paiement par PayPal
    }
}

public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        // Logique de paiement par virement bancaire
    }
}

public class PaymentProcessor
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentProcessor(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment()
    {
        _paymentMethod.ProcessPayment();
    }
}

