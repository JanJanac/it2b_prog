public class Intramon
{
    public string Jmeno { get; set; }
    public int AktualniZdravi { get; set; }
    public int MaximalniZdravi { get; set; }
    public int BonusSila { get; set; }
    public Utok ZakladniUtok { get; set; }
    public Utok SpecialniUtok { get; set; }

    bool Leceni {  get; set; }

    public Intramon(string jmeno, int maxZdravi, int bonusSila, Utok zakladni, Utok specialni)
    {
        Jmeno = jmeno;
        MaximalniZdravi = maxZdravi;
        AktualniZdravi = maxZdravi;
        BonusSila = bonusSila;
        ZakladniUtok = zakladni;
        SpecialniUtok = specialni;
        Leceni = false;
    }

    public void ProvedZakladniUtok(Intramon protivnik)
    {
        Console.WriteLine($"{Jmeno} pouzil {ZakladniUtok.Nazev}!");
        Console.WriteLine(ZakladniUtok.Popis);

        int celkovePoskozeni = ZakladniUtok.VratPoskozeni() + BonusSila;

        protivnik.SnizZdravi(celkovePoskozeni);
    }

    public void ProvedSpecialniUtok(Intramon protivnik)
    {
        Console.WriteLine($"{Jmeno} pouzil {SpecialniUtok.Nazev}!");
        Console.WriteLine(SpecialniUtok.Popis);

        int celkovePoskozeni = SpecialniUtok.VratPoskozeni() + BonusSila;

        protivnik.SnizZdravi(celkovePoskozeni);
    }

    public void SnizZdravi(int poskozeni)
    {
        AktualniZdravi = AktualniZdravi - poskozeni;

        if (AktualniZdravi < 0)
        {
            AktualniZdravi = 0;
        }

        Console.WriteLine($"{Jmeno} ztratil {poskozeni} zivotu.");
    }

    public void Uzdrav(int pocet)
    {
        if (Leceni == true)
        {
            Console.WriteLine($"{Jmeno} se uz v tomto souboji lecil");
            return;
        }

        AktualniZdravi = AktualniZdravi + pocet;

        if (AktualniZdravi > MaximalniZdravi)
        {
            AktualniZdravi = MaximalniZdravi;
        }

        Console.WriteLine($"{Jmeno} si doplnil zivoty na {AktualniZdravi}.");

        Leceni = true;
    }

    public bool JeNazivu()
    {
        if (AktualniZdravi > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void VypisInfo()
    {
        Console.WriteLine($"{Jmeno} - Zdravi: {AktualniZdravi}/{MaximalniZdravi}");
    }
}