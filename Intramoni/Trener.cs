public class Trener
{
    public string Jmeno { get; set; }
    public int Level { get; set; }
    public List<Intramon> Intramoni { get; set; }
    public Intramon VybranyIntramon { get; set; }

    public Trener(string jmeno)
    {
        Jmeno = jmeno;
        Level = 1;
        Intramoni = new List<Intramon>();
    }

    public void PridatIntramona(Intramon c)
    {
        Intramoni.Add(c);
    }

    public void ZvysLevel()
    {
        Level++;
        Console.WriteLine($"\n{Jmeno} postoupil na level {Level}!");
    }
}