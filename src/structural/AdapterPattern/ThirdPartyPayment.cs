namespace AdapterPattern;

public class ThirdPartyPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using third party payment gateway.");
    }
}