using TestAssignmentMindbox.Abstract;
using TestAssignmentMindbox.Exceptions;

namespace TestAssignmentMindbox.Figures;
public class Triangle : IFigure
{
    /// <summary>
    /// calculation precision based on double precision 
    /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
    /// </summary>
    private readonly double _eps = 1e-12; 
    private double _a;
    private double _b;
    private double _c;
    public double A
    {
        get => _a;
        init => _a = value;
    }

    public double B
    {
        get => _b;
        init => _b = value;
    }

    public double C
    {
        get => _c;
        init => _c = value;
    }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 ||  b <= 0 || c <= 0) 
            throw new ArgumentException("Side can not be equal or less than 0");

        if (IsSidesNotValide(a, b, c)) 
            throw new InvalidTrangleSidesException("The condition of the triangle " +
                "that any two sides are greater than thirds is not accomplish");

        A = a;
        B = b;
        C = c;
    }

    private bool IsSidesNotValide(double a, double b, double c)
    {
        if ( (a + b < c) || (b + c < a) || (c + a < b)) return true;
        return false;
    }

    public bool IsRightTriangle()
    {
        if ((Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2) < _eps) ||
                (Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2) < _eps) ||
            (Math.Pow(C, 2) + Math.Pow(A, 2) - Math.Pow(B, 2) < _eps))
        { 
            return true; 
        }
        return false;
    }

    public double GetArea()
    {
        double semiperim = (A + B + C) / 2;
        double ans = Math.Sqrt(semiperim * (semiperim - A)
            * (semiperim - B) * (semiperim - C));
        return ans;
    }
}