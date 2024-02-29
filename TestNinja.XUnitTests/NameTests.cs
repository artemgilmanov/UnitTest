namespace TestNinja.XUnitTests;

using Xunit;
using TestNinja.Fundamentals;

public class NameTests
{
  [Fact]
  public void MakeFullName_WhenCalled_ReturnsFullName()
  {
    var names = new Names();

    var result = names.MakeFullName("Firstname", "Lastname");

    // Assert.Equal("FirstName LastName", result, ignoreCase:true);
    // Assert.Contains("FirstName", result, StringComparison.InvariantCultureIgnoreCase);
    // Assert.StartsWith("FirstName", result, StringComparison.InvariantCultureIgnoreCase);
    // Assert.EndsWith("LastName", result, StringComparison.InvariantCultureIgnoreCase);
    Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
  }

  [Theory]
  [InlineData("Tim", "Tom", "Tim Tom")]
  [InlineData("Tim", "", "Tim ")]
  [InlineData("", "Tom", " Tom")]
  [InlineData("", "", "  ")]

  public void MakeFullName_AlwaysReturnValue_ReturnsTrue(string firstName, string lastName, string expected)
  {
    var names = new Names();

    var result = names.MakeFullName(firstName, lastName);

    //Assert.NotNull(result);
    Assert.False(string.IsNullOrEmpty(expected));
  }

  /*
  [Theory]
  [MemberData(nameof(DataShare.AlwaysReturnValue), MemberType = typeof(DataShare))]

  public void MakeFullName_AlwaysReturnValue_ReturnsTrue(string firstName, string lastName, string expected)
  {
    var names = new Names();

    var result = names.MakeFullName(firstName, lastName);

    //Assert.NotNull(result);
    Assert.False(string.IsNullOrEmpty(expected));
  }
  */

  /*
  [Theory]
  [AlwaysReturnValue]
  public void MakeFullName_AlwaysReturnValue_ReturnsTrue(string firstName, string lastName, string expected)
  {
    var names = new Names();

    var result = names.MakeFullName(firstName, lastName);

    //Assert.NotNull(result);
    Assert.False(string.IsNullOrEmpty(expected));
  }
  */

  [Fact]
  public void NickName_MustBeNull_ReturnTrue()
  {
    var names = new Names();

    Assert.Null(names.NickName);
  }

  [Fact]
  public void Name_MustNotBeNullAndHasAge_ReturnTrue()
  {
    var names = new Names();

    Assert.NotNull(names.Name);
    Assert.False(string.IsNullOrEmpty(names.Name));
    Assert.InRange(names.Age, 1, 100);
  }

  [Fact]
  public void GetSomethingByName_WhenCalled_ReturnsOne()
  {
    var names = new Names();

    var result = names.GetSomethingByName("John");

    Assert.Throws<ArgumentException>(() => names.GetSomethingByName(null));
    // var exceptionDetails = Assert.Throws<ArgumentException>(() => names.GetSomethingByName(null));
    // exceptionDetails.Message.Contains("Name is required");
    // Assert.Equal("Name is required", exceptionDetails.Message);
  }

  [Fact]
  public void CreateName_NameLengthGreaterThan10_ReturnsNames()
  {
    var result = NamesFactory.CreateName(11);

    Assert.IsType<Names>(result);
    // Assert.IsNotType<ShortNames>(result);
    // Assert.IsAssignableFrom<Names>(result);
  }
}

