using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Tomato";
        double price = 5.00;
        int quantity = 2;

        // Act
        this._inventory.AddProduct(name, price, quantity);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo($"Product Inventory:{Environment.NewLine}Tomato - Price: $5.00 - Quantity: 2"));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo($"Product Inventory:"));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string name = "Tomato";
        double price = 5.00;
        int quantity = 2;


        string name2 = "Bread";
        double price2 = 2.00;
        int quantity2 = 1;

        // Act
        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(name2, price2, quantity2);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo($"Product Inventory:{Environment.NewLine}Tomato - Price: $5.00 - Quantity: 2{Environment.NewLine}Bread - Price: $2.00 - Quantity: 1"));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string name = "Coca-Cola";
        double price = 2.50;
        int quantity = 2;
        
        string name2 = "Pepsi";
        double price2 = 5.00;
        int quantity2 = 2;
        
        // Act
        this._inventory.AddProduct(name, price, quantity);
        this._inventory.AddProduct(name2, price2, quantity2);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(15));
    }
}
