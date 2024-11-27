namespace Trial_Object_constructors;

public class Money
{
    public decimal Amount { get; private set; }
    public Currency Currency { get; private set; }

    public Money(decimal amount, Currency currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative.");

        Amount = amount;
        Currency = currency;
    }

    public void ChangeCurrency(CurrencyConverter converter, Currency newCurrency)
    {
        if (Currency == newCurrency) return;

        switch (Currency)
        {
            case Currency.Dollar:
                Amount = newCurrency == Currency.Euro
                    ? converter.DollarToEuro(Amount)
                    : converter.DollarToSEK(Amount);
                break;
            case Currency.Euro:
                Amount = newCurrency == Currency.Dollar
                    ? converter.EuroToDollar(Amount)
                    : converter.EuroToSEK(Amount);
                break;
            case Currency.SEK:
                Amount = newCurrency == Currency.Dollar
                    ? converter.SEKToDollar(Amount)
                    : converter.SEKToEuro(Amount);
                break;
        }

        Currency = newCurrency;
    }
}