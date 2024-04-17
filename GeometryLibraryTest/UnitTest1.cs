namespace GeometryLibraryTest;
using GeometryLibrary;

[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestSquareArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestSquarePerimeter()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }
}

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestRectangleArea()
    {
        // Arrange
        var rectangle = new Rectangle(6,4);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(24, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(6,4);

        // Act
        var result = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }
}
[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestTriangleArea()
    {
        // Arrange
        var triangle = new Triangle(6,4,3,2);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(12, result);
    }

    [TestMethod]
    public void TestTrianglePerimeter()
    {
        // Arrange
        var triangle = new Triangle(6,4,3,2);

        // Act
        var result = triangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(11, result);
    }
}
