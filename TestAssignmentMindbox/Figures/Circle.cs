using TestAssignmentMindbox.Abstract;

namespace TestAssignmentMindbox.Figures;

public class Circle : IFigure
{
    public readonly double  Radius;
    
    public Circle(double radius)
    {
        if (radius < 0) throw new ArgumentException("Radius can not be less than 0");
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
