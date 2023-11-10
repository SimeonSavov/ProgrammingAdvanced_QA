using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new[] { "cat" };
        string text = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new[] { "quick" };
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The ***** brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new[] { "quick brown", "dog" };
        string text = "The quick brown fox jumps over the lazy dog";
        string expected = "The *********** fox jumps over the lazy ***";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
