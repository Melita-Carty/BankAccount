using System;
public class BankAccount
{
    private decimal balance;

    public BankAccount()
    {
        balance = 0;
    }

    public void Deposit(decimal amount)
    {
        // Implement This Method
        
        // Hint: Increase the balance by the amount deposited
        // Hint: Ensure the amount is positive before adding to balance
        // Hint: Throw an exception or handle invalid amounts as needed

        if (amount > 0) {
            decimal newBalance = balance + amount;
            this.balance = newBalance;
        } else {
            throw new ArgumentException("Balance amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        // Implement This Method

        // Hint: Decrease the balance by the amount withdrawn
        // Hint: Ensure the amount is positive and does not exceed the current balance
        // Hint: Throw an exception or handle invalid amounts as needed

        if (amount <= this.balance)
        {
            this.balance -= amount;
        }
        else
        {
            throw new ArgumentException("Withdrawal amount cannot be greater than account balance.");
        }
    }

    public decimal GetBalance()
    {
        // Implement This Method

         // Hint: Return the current balance
        return this.balance;

    }
}