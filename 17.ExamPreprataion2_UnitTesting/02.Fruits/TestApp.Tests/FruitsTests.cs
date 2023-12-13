using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int>
        { 
            { "banana", 20 } 
        };
        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruit, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int> 
        { 
            { "apple", 3 },
            { "lemon", 20 }
        };

        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruit, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int>();
        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruit, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruit = null;
        string fruitName = "banana";

        // Act
        int result = Fruits.GetFruitQuantity(fruit, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int> 
        { 
            { "grapes", 10 } 
        };
        string? fruitName = null;

        // Act
        int result = Fruits.GetFruitQuantity(fruit, fruitName);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
