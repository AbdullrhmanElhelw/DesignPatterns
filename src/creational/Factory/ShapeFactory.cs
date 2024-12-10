namespace Factory;

public class ShapeFactory : IShapeFactory
{
    public IShape GetShape(Shapes shapes)
    {
        return shapes switch
        {
            Shapes.Circle => new Circle(),
            Shapes.Triangle => new Triangle(),
            _ => throw new Exception("Unknown Shape")
        };
    }

    public IDimension GetDimension(Dimensions dimensions)
    {
        return dimensions switch
        {
            Dimensions.Circular => new Circular(),
            Dimensions.Square => new Square(),
            Dimensions.Triangular => new Triangular(),
            _ => throw new Exception("Unknown Dimension")
        };
    }
}