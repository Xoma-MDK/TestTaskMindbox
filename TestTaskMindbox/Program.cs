using GeometryLibrary.Interfaces;
using GeometryLibrary.Shapes;

namespace TestTaskMindbox;

internal class Program
{
    static void Main()
    {
        IShape triangle = new Triangle(3.0, 4.0, 5.0);
        Console.WriteLine($"Площадь треугольника со сторонами 3, 4, 5 равна {triangle.CalculateArea()}");

        if (triangle is Triangle tri)
        {
            Console.WriteLine($"Треугольник является прямоугольным: {tri.IsRightAngled()}");
        }
    }
}
