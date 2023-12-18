using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _bankAccount = null!;

    [SetUp]
    public void SetUp()
    {
        this._bankAccount = new BankAccount(1000);
    }


    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange

        // Act
        double initialBalance = this._bankAccount.Balance;

        // Assert
        Assert.That(initialBalance, Is.EqualTo(1000));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double depositAmount = 500;

        // Act
        this._bankAccount.Deposit(depositAmount);

        // Assert
        Assert.That(this._bankAccount.Balance, Is.EqualTo(1500));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double depositAmount = -100;

        // Act & Assert
        Assert.That(() => this._bankAccount.Deposit(depositAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double withdrawalAmount = 200;

        // Act
        this._bankAccount.Withdraw(withdrawalAmount);

        // Assert
        Assert.That(this._bankAccount.Balance, Is.EqualTo(800));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double withdrawalAmount = -50.50;

        // Act & Assert
        Assert.That(() => this._bankAccount.Withdraw(withdrawalAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double withdrawalAmount = 1500;

        // Act & Assert
        Assert.That(() => this._bankAccount.Withdraw(withdrawalAmount), Throws.ArgumentException);
    }
}
