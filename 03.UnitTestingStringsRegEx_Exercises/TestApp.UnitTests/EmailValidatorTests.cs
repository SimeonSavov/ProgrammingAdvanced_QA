using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("simosavov@abv.bg")]
    [TestCase("simeon_savov@gmail.com")]
    [TestCase("simeon+21@yahoo.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("invalid mail@valid.domain")]
    [TestCase("valid%mail@in_valid.domain")]
    [TestCase("invalid/mail@invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
