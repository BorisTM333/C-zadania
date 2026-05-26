using System;

class BankKonto
{
    public string wlasciciel;
    public double saldo;
    public BankKonto(string wlasciciel, double saldoPoczatkowe)
    {
        this.wlasciciel = wlasciciel;
        this.saldo = saldoPoczatkowe;
    }

    public void wplata(double kwota)
    {
        if (kwota > 0)
        {
            saldo += kwota;
            Console.WriteLine($"Wpłacono {kwota} zł.");
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być dodatnia.");
        }
    }

    public void wyplata(double kwota)
    {
        if (kwota <= saldo && kwota > 0)
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłacono {kwota} zł.");
        }
        else
        {
            Console.WriteLine("Brak wystarczających środków lub nieprawidłowa kwota.");
        }
    }

    public void wyswietlSaldo()
    {
        Console.WriteLine($"Aktualne saldo konta ({wlasciciel}): {saldo} zł");
    }
}

class Program
{
    static void Main()
    {
        BankKonto konto = new BankKonto("Jan Kowalski", 1000);

        konto.wyswietlSaldo();
        konto.wplata(500);
        konto.wyplata(300);
        konto.wyswietlSaldo();
    }
}
