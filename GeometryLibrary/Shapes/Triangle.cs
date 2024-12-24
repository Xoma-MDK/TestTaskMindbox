using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Shapes;

public class Triangle : IShape
{
    public double SideA { get; private set; }
    public double SideB { get; private set; }
    public double SideC { get; private set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("The sides of the triangle must be positive.");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("The specified sides cannot form a triangle.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightAngled()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
    }
}
