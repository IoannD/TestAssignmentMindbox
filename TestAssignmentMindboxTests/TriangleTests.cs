using TestAssignmentMindbox.Exceptions;
using TestAssignmentMindbox.Figures;

namespace TestAssignmentMindboxTests;

public class TriangleTests
{
    [Theory]
    [InlineData(-1.0, 1.0, 1.0)]
    [InlineData(1.0, -1.0, 1.0)]
    [InlineData(1.0, 1.0, -1.0)]
    [InlineData(0.0, 1.0, 1.0)]
    [InlineData(1.0, 0.0, 1.0)]
    [InlineData(1.0, 1.0, 0.0)]
    public void Constructor_ThrowArgumentException(double a,
                                                   double b,
                                                   double c)
    {
        // Arrange
        Action act = () => new Triangle(a, b, c);

        // Act + Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Theory]
    [InlineData(5.0, 1.0, 1.0)]
    [InlineData(1.0, 5.0, 1.0)]
    [InlineData(1.0, 1.0, 5.0)]
    public void Constructor_InvalidTrangleSidesException(double a,
                                                         double b,
                                                         double c)
    {
        // Arrange
        Action act = () => new Triangle(a, b, c);

        // Act + Assert
        Assert.Throws<InvalidTrangleSidesException>(act);
    }

    [Fact]
    public void GetArea_CorrectResult()
    {
        // Arrange
        // right triangle is used for the test
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;

        // Act
        double correctArea = a * b / 2;
        
        Triangle triangle = new Triangle(a, b, c);
        double area = triangle.GetArea();

        // Assert
        Assert.Equal(correctArea, area);
    }

    [Fact]
    public void IsRightTriangle_True()
    {
        // Arrange
        double a = 3.0;
        double b = 4.0;
        double c = 5.0;
        Triangle triangle = new Triangle(a, b, c);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRightTriangle);
    }
}