namespace Trial_Object_constructors;

public class Account
{
    public Money Balance { get; private set; }
    public int Id { get; }

    public Account(Money initialBalance, int id)
    {
        if (initialBalance == null)
            throw new ArgumentNullException(nameof(initialBalance));

        Balance = initialBalance;
        Id = id;
    }

    public void Deposit(Money amount)
    {
        if (amount.Currency != Balance.Currency)
            throw new InvalidOperationException("Currencies must match for deposit.");

        Balance = new Money(Balance.Amount + amount.Amount, Balance.Currency);
    }

    public void Withdraw(Money amount)
    {
        if (amount.Currency != Balance.Currency)
            throw new InvalidOperationException("Currencies must match for withdrawal.");
        if (amount.Amount > Balance.Amount)
            throw new InvalidOperationException("Insufficient funds.");

        Balance = new Money(Balance.Amount - amount.Amount, Balance.Currency);
    }
}