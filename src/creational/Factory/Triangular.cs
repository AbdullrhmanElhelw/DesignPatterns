namespace Factory;

public class Triangular : IDimension
{
    public string GetDimension()
    {
        return "The Shape With " + typeof(Triangular) + "Dimension";
    }
}