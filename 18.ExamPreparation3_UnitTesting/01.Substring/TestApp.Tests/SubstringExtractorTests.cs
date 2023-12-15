using NUnit.Framework;
using System.Linq;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "Hello World!";
        string start = "H";
        string end = "!";
        string expected = "ello World";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello";
        string start = "W";
        string end = "lo";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello";
        string start = "He";
        string end = "!";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello";
        string start = "D";
        string end = "!";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = string.Empty;
        string start = "H";
        string end = "ello";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello World";
        string start = "Hello";
        string end = "HelloWorld";
        string expected = "Substring not found";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers
            (input, start, end);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
