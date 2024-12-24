using GeometryLibrary.Shapes;

namespace GeometryLibrary.Tests;

public class GeometryTests
{
    [Fact]
    public void CircleAreaCorrectRadiusReturnsArea()
    {
        var circle = new Circle(5);
        double area = circle.CalculateArea();
        Assert.Equal(Math.PI * 25, area, 5);
    }

    [Fact]
    public void TriangleAreaCorrectSidesReturnsArea()
    {
        var triangle = new Triangle(3, 4, 5);
        double area = triangle.CalculateArea();
        Assert.Equal(6, area, 5);
    }

    [Fact]
    public void TriangleIsRightAngledCorrectSidesReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void TriangleIsRightAngledIncorrectSidesReturnsFalse()
    {
        var triangle = new Triangle(2, 2, 3);
        Assert.False(triangle.IsRightAngled());
    }

    [Fact]
    public void CircleAreaNegativeRadiusThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void TriangleAreaInvalidSidesThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}