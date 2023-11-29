using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData =
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3",
        };

        // Act
        Article result = this._article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Author = "Simeon",
                    Content = "Somebody",
                    Title = "The Best Ever"
                },

                new Article()
                {
                    Author = "Sava",
                    Content = "Video Recording",
                    Title = "For the Best Ever"
                },
            }
        };

        string expected = $"For the Best Ever - Video Recording: Sava{Environment.NewLine}The Best Ever - Somebody: Simeon";

        // Act
        string actual = this._article.GetArticleList(inputArticle, "title");

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article inputArticle = new Article() { };

        // Act
        string actual = this._article.GetArticleList(inputArticle, "NoCriteria");

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
