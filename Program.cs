using System;
using Trial_Object_constructors;

class Program
{
    static void Main(string[] args)
    {
        // Create a CurrencyConverter
        var converter = new CurrencyConverter(0.095m, 0.085m, 1m);

        // Create a Money object
        var money = new Money(100, Currency.Dollar);
        Console.WriteLine($"Initial: {money.Amount} {money.Currency}");

        // Change currency from Dollar to Euro
        money.ChangeCurrency(converter, Currency.Euro);
        Console.WriteLine($"After conversion to Euro: {money.Amount} {money.Currency}");

        // Create an account with an initial balance
        var account = new Account(money, 1);
        Console.WriteLine($"Account Balance: {account.Balance.Amount} {account.Balance.Currency}");

        // Deposit
        var deposit = new Money(50, Currency.Euro);
        account.Deposit(deposit);
        Console.WriteLine($"After deposit: {account.Balance.Amount} {account.Balance.Currency}");

        // Withdrawal
        var withdrawal = new Money(30, Currency.Euro);
        account.Withdraw(withdrawal);
        Console.WriteLine($"After withdrawal: {account.Balance.Amount} {account.Balance.Currency}");
    }
}