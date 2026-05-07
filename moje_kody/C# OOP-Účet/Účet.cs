public class Ucet
{
    public double Zustatek { get; set; }
    public int Zalozeni { get; set; }
    private string Heslo;

    public Ucet(double zustatek, int zalozeni, string heslo)
    {
        Zustatek = zustatek;
        Zalozeni = zalozeni;
        Heslo = heslo;
    }

    public void ZobrazZustatek(string heslo)
    {
        if (heslo == Heslo)
        {
            Console.WriteLine($"Zustatek na tvem uctu je: {Zustatek} Kc");
        }
        else
        {
            Console.WriteLine("Nemas pristup k zustatku");
        }
    }

    public void ZobrazZalozeni()
    {
        Console.WriteLine($"Ucet jsi zalozil pred {Zalozeni} lety");
    }

    public void Vlozit(double vklad)
    {
        Zustatek = (double)Zustatek + vklad;
        Console.WriteLine($"Aktualne mas na uctu: {Zustatek} Kc");
    }

    public void Vyber(double vyber)
    {
        if (vyber > Zustatek)
        {
            Console.WriteLine($"Nemas dostatek penez na takovy vyber");
        }
        else
        {
            Zustatek = (double)Zustatek - vyber;
            Console.WriteLine($"Aktualne mas na uctu: {Zustatek} Kc");
        }
    }
}