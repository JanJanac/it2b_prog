public class Utok
{
    public string Nazev { get; set; }
    public int Poskozeni { get; set; }
    public string Popis { get; set; }

    public Utok(string nazev, int poskozeni, string popis)
    {
        Nazev = nazev;
        Poskozeni = poskozeni;
        Popis = popis;
    }

    public int VratPoskozeni()
    {
        return Poskozeni;
    }
}