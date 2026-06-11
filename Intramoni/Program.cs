class Program
{
    static void Main()
    {
        Console.WriteLine("Vitej na intru!");
        Console.WriteLine("Zadej sve jmeno: ");
        string jmenoHrace = Console.ReadLine();

        Trener hrac = new Trener(jmenoHrace);
        Trener pocitac = new Trener("Pani Hackova");

        Random rnd = new Random();

        Utok Zalehnuti = new Utok("Zalehunti", 8, "Goonzier na tebe skocil");
        Utok Gunidlo = new Utok("Gunidlo", 18, "Goonzier ti vygunil nohu");
        Intramon Goonzier = new Intramon("Goonzier", 150, 0, Zalehnuti, Gunidlo);

        Utok Ponozky = new Utok("Ponozky", 10, "Smradoch po tobe hodil ponozky");
        Utok ZpocenePodpazi = new Utok("ZpocenePodpazi", 17, "Smradoch se zase neumyl");
        Intramon Smradoch = new Intramon("Smradoch", 110, 1, Ponozky, ZpocenePodpazi);

        Utok PomaluSnejksy = new Utok("PomaluSnejksy", 11, "Opicojd te napalil");
        Utok MastickaNaPrdel = new Utok("MastickaNaPrdel", 19, "Opicojd te namastil");
        Intramon Opicojd = new Intramon("Opicojd", 105, 2, PomaluSnejksy, MastickaNaPrdel);

        Utok BasketbalovyMic = new Utok("BasketbalovyMic", 9, "Headshot od Diharda");
        Utok KFC = new Utok("KFC", 19, "Posral ses z KFC");
        Intramon DihardRolak = new Intramon("Dihard Rolak", 130, 0, BasketbalovyMic, KFC);

        Utok Pleska = new Utok("Plesku", 9, "Odraz svetla z plesky");
        Utok CholerickyZachvat = new Utok("CholerickyZachvat", 16, "Nemas ustlano a uklizeno");

        pocitac.PridatIntramona(new Intramon("Gargamel", 170, 1, Pleska, CholerickyZachvat));

        pocitac.VybranyIntramon = pocitac.Intramoni[0];

        Console.WriteLine("\nVyber si sveho Intraka:");
        Console.WriteLine(" 1 - Goonzier (HP = 150)");
        Console.WriteLine(" 2 - Smradoch (HP = 110)");
        Console.WriteLine(" 3 - Opicojd (HP = 105)");
        Console.WriteLine(" 4 - DihardRolak (HP = 130)");
        Console.Write("\nTvoje volba: ");

        int volbaIntramona = int.Parse(Console.ReadLine());

        while (volbaIntramona < 1 || volbaIntramona > 4)
        {
            Console.WriteLine("\nSpatna volba, zadej cislo 1-4:");
            volbaIntramona = int.Parse(Console.ReadLine());
        }

        if (volbaIntramona == 1)
        {
            hrac.PridatIntramona(Goonzier);
        }
        else if (volbaIntramona == 2)
        {
            hrac.PridatIntramona(Smradoch);
        }
        else if (volbaIntramona == 3)
        {
            hrac.PridatIntramona(Opicojd);
        }
        else
        {
            hrac.PridatIntramona(DihardRolak);
        }

        hrac.VybranyIntramon = hrac.Intramoni[0];

        Console.WriteLine($"\nVybral sis: {hrac.VybranyIntramon.Jmeno}");
        Console.WriteLine($"Protivnik je: {pocitac.Jmeno}");
        Console.WriteLine($"Protivnikuv Intramon: {pocitac.VybranyIntramon.Jmeno}");

        bool hratZnovu = true;

        while (hratZnovu)
        {
            hrac.VybranyIntramon.AktualniZdravi = hrac.VybranyIntramon.MaximalniZdravi;
            pocitac.VybranyIntramon.AktualniZdravi = pocitac.VybranyIntramon.MaximalniZdravi;
            Console.WriteLine("\n-- Zacina souboj --");

            bool hraBezi = true;
            bool leceniPouzito = false;

            while (hraBezi)
            {
                Console.WriteLine($"\nTVUJ TAH");
                Console.WriteLine($" 1 - Zakladni utok: {hrac.VybranyIntramon.ZakladniUtok.Nazev}");
                Console.WriteLine($" 2 - Specialni utok: {hrac.VybranyIntramon.SpecialniUtok.Nazev}");
                if (!leceniPouzito)
                {
                    Console.WriteLine(" 3 - Leceni (lze pouzit jen jednou za souboj)");
                }
                Console.Write("\nTvoje volba: ");

                int volbaUtoku = int.Parse(Console.ReadLine());

                Console.Write("\n");

                while (volbaUtoku < 1 || volbaUtoku > 3)
                {
                    Console.WriteLine("Spatna volba, zadej cislo 1-3:");
                    volbaUtoku = int.Parse(Console.ReadLine());
                }

                if (volbaUtoku == 1)
                {
                    hrac.VybranyIntramon.ProvedZakladniUtok(pocitac.VybranyIntramon);
                }
                else if (volbaUtoku == 2)
                {
                    hrac.VybranyIntramon.ProvedSpecialniUtok(pocitac.VybranyIntramon);
                }
                else if (volbaUtoku == 3)
                {
                    hrac.VybranyIntramon.Uzdrav(20);
                    leceniPouzito = true;
                }

                if (pocitac.VybranyIntramon.JeNazivu() == false)
                {
                    Console.WriteLine("Vyhral jsi souboj!");

                    hrac.ZvysLevel();

                    Console.WriteLine($"Tvuj aktualni level je {hrac.Level}");

                    int bonusoveZivoty = hrac.Level * 5;
                    pocitac.VybranyIntramon.MaximalniZdravi = pocitac.VybranyIntramon.MaximalniZdravi + bonusoveZivoty;

                    hraBezi = false;
                    break;
                }

                Console.WriteLine("\nTAH POCITACE");

                int utokPocitace = rnd.Next(1, 3);

                if (utokPocitace == 1)
                {
                    pocitac.VybranyIntramon.ProvedZakladniUtok(hrac.VybranyIntramon);
                }
                else
                {
                    pocitac.VybranyIntramon.ProvedSpecialniUtok(hrac.VybranyIntramon);
                }

                if (hrac.VybranyIntramon.JeNazivu() == false)
                {
                    Console.WriteLine("Tvuj Intramon prohral...");
                    pocitac.ZvysLevel();
                    hraBezi = false;
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("STAV SOUBOJE");

                hrac.VybranyIntramon.VypisInfo();
                pocitac.VybranyIntramon.VypisInfo();
            }

            Console.WriteLine("\nChces bojovat znovu? (a/n)");
            string odpoved = Console.ReadLine();

            if (odpoved != "a")
            {
                hratZnovu = false;
            }
        }
    }
}