namespace StrategyPattern.FirstExample;

public class PayPalPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount) =>
        Console.WriteLine($"Paying {amount} using PayPal.");
}