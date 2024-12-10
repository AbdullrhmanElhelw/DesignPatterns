namespace AdapterPattern;

public class Adapter : PaymentProcessorTarget
{
    private readonly ThirdPartyPayment _thirdPartyPayment;

    public Adapter(ThirdPartyPayment thirdPartyPayment)
    {
        _thirdPartyPayment = thirdPartyPayment;
    }

    public override void Pay(decimal amount)
    {
        _thirdPartyPayment.Pay(amount);
    }
}