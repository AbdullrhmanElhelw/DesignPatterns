public class ShapeFactory : IShapeFactory
{
    public IShape GetShape(Shapes shapes)
    {
        switch (shapes)
        {
            case Shapes.Circle:
                return new Circle();
                break;
            case Shapes.Triangle:
                return new Triangle();
                break;
            default:
                throw new Exception("Unknown Shape");
        }
    }

    public IDimension GetDimension(Dimensions dimensions)
    {
        switch (dimensions)
        {
            case Dimensions.Circular:
                return new Circular();
                break;
            case Dimensions.Square:
                return new Square();
                break;
            case Dimensions.Triangular:
                return new Triangular();
                break;
            default:
                throw new Exception("Unknown Dimension");
        }
    }
}