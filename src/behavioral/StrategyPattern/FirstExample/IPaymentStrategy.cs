namespace StrategyPattern.FirstExample;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}