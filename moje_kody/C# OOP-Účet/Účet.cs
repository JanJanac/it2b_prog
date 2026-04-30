public class Ucet
{
    public double Zustatek { get; set; }
    public int Zalozeni { get; set; }

    public Ucet(double zustatek, int zalozeni)
    {
        Zustatek = zustatek;
        Zalozeni = zalozeni;
    }

    public void ZobrazZustatek()
    {
     Console.WriteLine($"Zustatek na tvem uctu je: {Zustatek} Kc");
    }

    public void ZobrazZalozeni()
    {
        Console.WriteLine($"Ucet jsi zalozil pred {Zalozeni} lety");
    }

    public void Vlozit(double vklad)
    {
        Zustatek = (double) Zustatek + vklad;
        Console.WriteLine($"Aktualne mas na uctu: {Zustatek} Kc");
    }

    public void Vyber (double vyber)
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