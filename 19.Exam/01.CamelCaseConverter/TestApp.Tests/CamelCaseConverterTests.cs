using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "hello";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "hello";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "hello world testing";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "helloWorldTesting";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "heLlo worLD teStInG";

        // Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);
        string expected = "helloWorldTesting";

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
