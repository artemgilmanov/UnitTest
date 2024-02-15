using TestNinja.Fundamentals;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
  [TestFixture]
  public class ReservationTests
  {
    [Test]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
      // Arrange. Initialize objects and set the value of the data.
      var reservation = new Reservation();

      // Act
      var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

      // Assert
      Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_MadeBySameUser_ReturnsTrue()
    {
      // Arrange. Initialize objects and set the value of the data.
      var user = new User();
      var reservation = new Reservation { MadeBy = user };
      
      // Act
      var result = reservation.CanBeCancelledBy(user);

      // Assert
      Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_MadeByAnotherUser_ReturnsFalse()
    {
      // Arrange. Initialize objects and set the value of the data.
      var userOne = new User();
      var userTwo = new User();
      var reservation = new Reservation { MadeBy = userOne };

      // Act
      var result = reservation.CanBeCancelledBy(userTwo);

      // Assert
      Assert.That(result, Is.False);
    }
  }
}
