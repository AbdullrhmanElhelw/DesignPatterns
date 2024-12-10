namespace AdapterPattern;

public class Program
{
    public static void Main()
    {
        PaymentProcessorTarget paymentProcessor = new Adapter(new ThirdPartyPayment());
        paymentProcessor.Pay(100);
    }
}