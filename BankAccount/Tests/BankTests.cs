using System.Runtime.CompilerServices;
using NUnit.Framework;

namespace Kata6UnitTesting.Tests;

public class BankTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void GetBalance()
    /*
    Assert that the account balance is returned
    */
    {
        // Arrange
        var bankAccount = new BankAccount();

        // Act
        var balance = bankAccount.GetBalance();

        // Assert
        decimal expected = 0;
        Assert.That(balance, Is.EqualTo(expected));
    }

    [Test]
    public void Deposit_WhenPositiveAmount()
    /*
    When a positive amount is deposited
    Assert that the bank account balance is increased correctly
    */
    {
        // Arrange
        var bankAccount = new BankAccount();
        var depositAmount = 1;

        // Act
        bankAccount.Deposit(depositAmount);

        // Assert
        decimal expected = 1;
        Assert.That(bankAccount.GetBalance(), Is.EqualTo(expected));
    }

    [Test]
    public void Deposit_WhenNegativeAmount()
    /*
    When a negative amount is deposited
    Assert that the correct exception and message are raised
    And that the account balance is unchanged
    */
    {
        // Arrange
        var bankAccount = new BankAccount();
        var depositAmount = -1;

        // Act
        // Assert
        var ex = Assert.Throws<ArgumentException>(() => bankAccount.Deposit(depositAmount));
        Assert.That(ex.Message, Is.EqualTo("Balance amount must be positive."));
    }

    [Test]
    public void Withdraw_WhenWithdrawalSmallerThanBalance()
    /*
    When a withdrawal is made which is smaller than the balance
    Assert that the balance decreases by the correct amount
    */
    {
        // Arrange
        var bankAccount = new BankAccount();
        var withdrawalAmount = 5;
        bankAccount.Deposit(20);

        // Act
        bankAccount.Withdraw(withdrawalAmount);

        // Assert
        decimal expected = 15;
        Assert.That(bankAccount.GetBalance(), Is.EqualTo(expected));
    }

    [Test]
    public void Withdraw_WhenWithdrawalGreaterThanBalance()
    /*
    When a withdrawal is made which is greater than the balance
    Assert that the correct exception and message are thrown
    And that the balance is unchanged
    */
    {
        // Arrange
        var bankAccount = new BankAccount();
        var withdrawalAmount = 30;
        decimal bankBalance = 20;

        bankAccount.Deposit(bankBalance);

        // Act
        // Assert
        var ex = Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(withdrawalAmount));
        Assert.That(ex.Message, Is.EqualTo("Withdrawal amount cannot be greater than account balance."));
        Assert.That(bankAccount.GetBalance(), Is.EqualTo(bankBalance));
    }
}