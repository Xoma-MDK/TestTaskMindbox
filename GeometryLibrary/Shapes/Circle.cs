using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Shapes;

public class Circle : IShape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("The radius cannot be negative.");
        }
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
