using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int positions = 0;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "abc";
        int positions = 0;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo("abc"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";
        int positions = 2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo("deabc"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";
        int positions = -2;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo("deabc"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";
        int positions = 6;

        // Act
        string result = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(result, Is.EqualTo("eabcd"));
    }
}
