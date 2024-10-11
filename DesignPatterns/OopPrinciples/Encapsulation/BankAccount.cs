namespace DesignPatterns.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount to deposit must be positive.");
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The amount to withdraw must be positive.");
        }

        if(_balance < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }

        _balance -= amount;
    }
}