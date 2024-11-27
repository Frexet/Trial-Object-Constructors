namespace Trial_Object_constructors;

public class CurrencyConverter
{
    public decimal Dollar { get; }
    public decimal Euro { get; }
    public decimal SEK { get; }

    public CurrencyConverter(decimal dollar, decimal euro, decimal sek)
    {
        Dollar = dollar;
        Euro = euro;
        SEK = sek;
    }

    public decimal DollarToEuro(decimal amount) => amount * (Euro / Dollar);
    public decimal DollarToSEK(decimal amount) => amount * (SEK / Dollar);
    public decimal EuroToDollar(decimal amount) => amount * (Dollar / Euro);
    public decimal EuroToSEK(decimal amount) => amount * (SEK / Euro);
    public decimal SEKToDollar(decimal amount) => amount * (Dollar / SEK);
    public decimal SEKToEuro(decimal amount) => amount * (Euro / SEK);
}