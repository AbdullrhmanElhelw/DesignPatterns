using StrategyPattern.FirstExample;
using StrategyPattern.SecondExample;

#region Example 1  Payment Methods

IPaymentStrategy paymentStrategy = new CreditCardPaymentStrategy();

PaymentContext paymentContext = new PaymentContext(paymentStrategy);

paymentContext.Pay(100);

#endregion Example 1  Payment Methods

#region Example 2  Sort Strategies

var list = new List<int> { 3, 2, 1, 5, 4 };

var sortStrategy = new QuickSort<int>();

var sortContext = new SortContext<int>(sortStrategy);

sortContext.Sort(list);

Console.WriteLine(string.Join(", ", list));

#endregion Example 2  Sort Strategies