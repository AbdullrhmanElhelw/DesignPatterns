namespace Factory;

public class Circular : IDimension
{
    public string GetDimension()
    {
        return "The Shape With " + typeof(Circular) + "Dimension";
    }
}