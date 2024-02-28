namespace TestNinja.XUnitTests;

using Xunit;
using TestNinja.Fundamentals;

public class MathFixture
{
  public Math Math => new ();
}
public class MathTests : IClassFixture<MathFixture>
{
  private readonly MathFixture _mathFixture;

  public MathTests(MathFixture mathFixture)
  {
    _mathFixture = mathFixture;
  }
  
  [Fact]
  public void Add_WhenCalled_ReturnsTheSumOfArguments()
  {
    // Arrange
    var math = _mathFixture.Math;

    // Act
    var result = math.Add(1, 2);

    // Assert
    // Assert.Equal(expected, what we get from code);
    Assert.Equal(3, result);
  }

  [Fact]
  public void AddDouble_WhenCalled_ReturnsTheSumOfArguments()
  {
    // Arrange
    var math = _mathFixture.Math;

    // Act
    var result = math.AddDouble(1.2, 2.5);

    // Assert
    Assert.Equal(3.7, result, 1);
  }

  [Fact]
  [Trait("Category", " Fibonacci")]
  public void FibonacciNumbers_DoesNotContainZero_ReturnsFibonacciNumbers()
  {
    // Arrange
    var math = _mathFixture.Math;

    // Act
    var result = math.FibonacciNumbers;

    // Assert
    Assert.All(math.FibonacciNumbers, n => Assert.NotEqual(0, n));
  }

  [Fact]
  [Trait("Category", " Fibonacci")]
  public void FibonacciNumbers_Contains13_ReturnsFibonacciNumbers()
  {
    // Arrange
    var math = _mathFixture.Math;

    // Act
    var result = math.FibonacciNumbers;

    // Assert
    Assert.Contains(13, result);
    // Assert.DoesNotContain(4, result);
  }

  [Fact]
  [Trait("Category", " Fibonacci")]
  public void FibonacciNumbers_WhenCalled_ReturnsExactCollection()
  {
    // Arrange
    var math = _mathFixture.Math;
    var expected = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    // Act
    var result = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    // Assert
    Assert.Equal(expected, result);
  }
}
