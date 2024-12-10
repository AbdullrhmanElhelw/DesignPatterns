namespace AdapterPattern;

public class PaymentProcessorTarget
{
    public virtual void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using payment processor.");
    }
}