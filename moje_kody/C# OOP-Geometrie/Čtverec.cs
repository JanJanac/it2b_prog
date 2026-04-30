public class Ctverec
{
    public int Strana { get; set; }

    public Ctverec(int strana)
    {
        Strana = strana;
    }

    public void Obsah()
    {
     Console.WriteLine($"Obsah ctverce je: {Strana * Strana}");
    }

    public void Obvod()
    {
        Console.WriteLine($"Obvod ctverce je: {Strana * 4}");
    }

}