namespace StrategyPattern.FirstExample;

public class PaymentContext
{
    private readonly IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Pay(int amount) =>
        _paymentStrategy.Pay(amount);
}