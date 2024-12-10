namespace StrategyPattern.FirstExample;

public class CreditCardPaymentStrategy : IPaymentStrategy
{
    public void Pay(decimal amount) =>
        Console.WriteLine($"Paying {amount} using credit card.");
}