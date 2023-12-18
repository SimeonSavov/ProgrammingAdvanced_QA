using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<int, int> numbers = new();
        int number = 0;

        // Act
        var result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 1;

        // Act
        var result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> exepcted = new() { { 1, 1 } };

        // Assert
        Assert.That(result, Is.EqualTo(exepcted));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 1223334444;

        // Act
        var result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> exepcted = new() 
        {
            { 1, 1 }, 
            { 2, 2 }, 
            { 3, 3 }, 
            { 4, 4 } 
        };

        // Assert
        Assert.That(result, Is.EqualTo(exepcted));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -1223344;

        // Act
        var result = NumberFrequency.CountDigits(number);
        Dictionary<int, int> exepcted = new()
        {
            { 1, 1 },
            { 2, 2 },
            { 3, 2 },
            { 4, 2 }
        };

        // Assert
        Assert.That(result, Is.EqualTo(exepcted));
    }
}
