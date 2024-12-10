namespace DecoratorPattern;

public class HandlerDecorator : IHandler
{
    private readonly IHandler _handler;

    public HandlerDecorator(IHandler handler)
    {
        _handler = handler;
    }

    public virtual void Handle()
    {
        _handler.Handle();
    }
}