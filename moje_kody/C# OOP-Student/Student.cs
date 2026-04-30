public class Student
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }

    private List<int> Znamky;

    public Student(string jmeno, int vek, string trida)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();
    }

    public void PridatZnamku(int novaZnamka)
    {
        Znamky.Add(novaZnamka);
    }

    public void VypisZnamky()
    {
        Console.WriteLine("Znamky studenta: ");
        foreach (int z in Znamky)
        {
            Console.WriteLine("   " + z);
        }
    }

    public void SmazatZnamku(int Znamka)
    {
        if (Znamky.Contains(Znamka))
        {
            Znamky.Remove(Znamka);
        }
    }

    public double Prumer()
    {
        if (Znamky.Count == 0)
        {
            return 0;
        }

        int soucet = 0;

        foreach (int z in Znamky)
        {
            soucet += z;
        }

        return (double) soucet / Znamky.Count;
    }

    public void VypisInfo()
    {
        Console.WriteLine($"Jmeno: {Jmeno} ");
        Console.WriteLine($"Vek: {Vek} ");
        Console.WriteLine($"Trida: {Trida} ");
        Console.WriteLine($"Prumer: {Prumer()} ");

        Console.WriteLine("Znamky:");
        foreach (int z in Znamky)
        {
            Console.WriteLine("   " + z);
        }
    }
}