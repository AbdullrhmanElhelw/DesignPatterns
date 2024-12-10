namespace PrototypePattern;

public interface IPrototype<out T> where T : class
{
    T Clone();

    T DeepClone();
}