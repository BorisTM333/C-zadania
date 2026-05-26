using System;

class BiletKino
{
    private string film;
    private int numerMiejsca;
    private double cena;
    private bool czyZarezerwowany;

    public BiletKino(string film, int numerMiejsca, double cena)
    {
        this.film = film;
        this.numerMiejsca = numerMiejsca;
        this.cena = cena;
        this.czyZarezerwowany = false;
    }

    public void ZarezerwujBilet()
    {
        if (czyZarezerwowany)
        {
            Console.WriteLine($"Blad: Bilet na film '{film}' (miejsce {numerMiejsca}) jest juz zarezerwowany!");
        }
        else
        {
            czyZarezerwowany = true;
            Console.WriteLine($"Sukces: Bilet na film '{film}' (miejsce {numerMiejsca}) zostal pomyslnie zarezerwowany.");
        }
    }

    public void AnulujRezerwacje()
    {
        if (!czyZarezerwowany)
        {
            Console.WriteLine($"Blad: Nie mozna anulowac, poniewaz bilet na film '{film}' nie byl zarezerwowany.");
        }
        else
        {
            czyZarezerwowany = false;
            Console.WriteLine($"Sukces: Rezerwacja biletu na film '{film}' (miejsce {numerMiejsca}) zostala anulowana.");
        }
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine("\n--- INFORMACJE O BILECIE ---");
        Console.WriteLine($"Film: {film}");
        Console.WriteLine($"Numer miejsca: {numerMiejsca}");
        Console.WriteLine($"Cena: {cena:F2} PLN");
        Console.WriteLine($"Status rezerwacji: {(czyZarezerwowany ? "Zarezerwowany" : "Wolny")}");
        Console.WriteLine("----------------------------");
    }
}

class Program
{
    static void Main()
    {
        BiletKino bilet1 = new BiletKino("Incepcja", 12, 25.50);
        BiletKino bilet2 = new BiletKino("Diuna", 45, 30.00);

        Console.WriteLine("=== TEST BILETU 1 ===");
        bilet1.WyswietlInformacje();
        bilet1.ZarezerwujBilet();
        bilet1.ZarezerwujBilet();
        bilet1.WyswietlInformacje();

        Console.WriteLine("\n=== TEST BILETU 2 ===");
        bilet2.WyswietlInformacje();
        bilet2.AnulujRezerwacje();
        bilet2.ZarezerwujBilet();
        bilet2.AnulujRezerwacje();
        bilet2.WyswietlInformacje();
    }
}
