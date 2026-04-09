class Program
{
    static List<string> nazvyFilmu = new List<string> { "Inception", "Matrix", "Gladiator" };
    static List<int> rokyFilmu = new List<int> { 2010, 1999, 2000 };
    static List<double> hodnoceniFilmu = new List<double> { 8.8, 8.7, 8.5 };

    static void Main()
    {
        bool pokracovat = true;
        while (pokracovat)
        {
            Console.WriteLine("\n--- FILMOVÁ DATABÁZE ---");
            Console.WriteLine("1. Přidat film");
            Console.WriteLine("2. Vypsat filmy podle roku");
            Console.WriteLine("3. Vyhledat film podle textu");
            Console.WriteLine("4. Průměrné hodnocení všech filmů");
            Console.WriteLine("5. Smazat film podle názvu");
            Console.WriteLine("6. Konec");
            Console.Write("Vyber možnost: ");

            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1": PridatFilm(); break;
                case "2": VypisPodleRoku(); break;
                case "3": VyhledatPodleTextu(); break;
                case "4": PrumerneHodnoceni(); break;
                case "5": SmazatFilm(); break;
                case "6": pokracovat = false; break;
                default: Console.WriteLine("Neplatná volba."); break;
            }
        }
    }

    static void PridatFilm()
    {
        Console.Write("Název filmu: ");
        nazvyFilmu.Add(Console.ReadLine());
        Console.Write("Rok vydání: ");
        rokyFilmu.Add(int.Parse(Console.ReadLine()));
        Console.Write("Hodnocení (0-10): ");
        hodnoceniFilmu.Add(double.Parse(Console.ReadLine()));
        Console.WriteLine("Film přidán!");
    }

    static void VypisPodleRoku()
    {
        Console.Write("Zadej rok: ");
        int hledanyRok = int.Parse(Console.ReadLine());
        Console.WriteLine($"Filmy z roku {hledanyRok}:");

        for (int i = 0; i < rokyFilmu.Count; i++)
        {
            if (rokyFilmu[i] == hledanyRok)
            {
                Console.WriteLine($"- {nazvyFilmu[i]} (Hodnocení: {hodnoceniFilmu[i]})");
            }
        }
    }

    static void VyhledatPodleTextu()
    {
        Console.Write("Zadej text k vyhledání: ");
        string hledanyText = Console.ReadLine().ToLower();

        for (int i = 0; i < nazvyFilmu.Count; i++)
        {
            if (nazvyFilmu[i].ToLower().Contains(hledanyText))
            {
                Console.WriteLine($"- {nazvyFilmu[i]} [{rokyFilmu[i]}] (Hodnocení: {hodnoceniFilmu[i]})");
            }
        }
    }

    static void PrumerneHodnoceni()
    {
        if (hodnoceniFilmu.Count == 0) return;
        double prumer = hodnoceniFilmu.Average();
        Console.WriteLine($"Průměrné hodnocení všech filmů je: {prumer:F2}");
    }

    static void SmazatFilm()
    {
        Console.Write("Zadej přesný název filmu ke smazání: ");
        string smazat = Console.ReadLine();

        for (int i = nazvyFilmu.Count - 1; i >= 0; i--)
        {
            // Porovnáváme ignorujíce velká/malá písmena
            if (nazvyFilmu[i].Equals(smazat, StringComparison.OrdinalIgnoreCase))
            {
                nazvyFilmu.RemoveAt(i);
                rokyFilmu.RemoveAt(i);
                hodnoceniFilmu.RemoveAt(i);
                Console.WriteLine("Film byl smazán.");
            }
        }
    }
}