using System;

public class Zamowienie
{
    public string NazwaDania { get; set; }
    public double Cena { get; set; }
    public string Status { get; set; }

    public Zamowienie(string nazwaDania, double cena, string status)
    {
        NazwaDania = nazwaDania;
        Cena = cena;
        Status = status;
    }

    public void ZmienStatus(string nowyStatus)
    {
        Status = nowyStatus;
    }

    public void WyswietlZamowienie()
    {
        Console.WriteLine($"Danie: {NazwaDania}, Cena: {Cena}, Status: {Status}");
    }
}
