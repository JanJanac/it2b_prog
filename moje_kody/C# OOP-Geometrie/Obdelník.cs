ublic class Obdelnik
{
    public int Vyska { get; set; }
    public int Sirka { get; set; }

    public Obdelnik(int vyska, int sirka)
    {
        Vyska = vyska;
        Sirka = sirka;
    }

    public void Obsah()
    {
        Console.WriteLine($"Obsah obdelniku je: {Vyska * Sirka}");
    }

    public void Obvod()
    {
        Console.WriteLine($"Obvod obdelniku je: {(Vyska + Sirka) * 2}");
    }

}
