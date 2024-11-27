namespace Trial_Object_constructors;

class Program
{
    static void Main()
    {
        var converter = new CurrencyConverter(0.095m, 0.085m, 1m);
        var money = new Money(100m, Currency.SEK);

        money.ChangeCurrency(converter, Currency.Dollar);
        Console.WriteLine($"Amount: {money.Amount}, Currency: {money.Currency}");

        var account = new Account
        {
            Id = 1,
            Balance = money
        };

        Console.WriteLine($"Account ID: {account.Id}, Balance: {account.Balance.Amount} {account.Balance.Currency}");
    }
}