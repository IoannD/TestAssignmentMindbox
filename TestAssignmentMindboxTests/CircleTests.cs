using TestAssignmentMindbox.Abstract;
using TestAssignmentMindbox.Figures;

namespace TestAssignmentMindboxTests;

public class CircleTests
{
    [Fact]
    public void Constructor_ThrowArgumentException()
    {
        // Arrange
        Action act = () => new Circle(-1.0);

        // Act + Assert
        Assert.Throws<ArgumentException>(act);
    }

    [Fact]
    public void GetArea_ReturnZero()
    {
        // Arrange
        Circle circle = new Circle(0);
        IFigure figure = new Circle(0);
        
        // Act
        double circleArea = circle.GetArea();
        double figureAree = figure.GetArea();

        // Assert
        Assert.Equal(0, circleArea);
        Assert.Equal(0, figureAree);
    }

    [Fact]
    public void GetArea_CorrectResult()
    {
        // Arrange
        double radius = 2.5;
        Circle circle = new Circle(radius);
        IFigure figure = new Circle(radius);

        // Act
        double correctArea = Math.PI * Math.Pow(radius, 2);
        double circleArea = circle.GetArea();
        double figureAree = figure.GetArea();

        // Assert
        Assert.Equal(correctArea, circleArea);
        Assert.Equal(correctArea, figureAree);

    }
}