class Program
{
    static void Main()
    {
        Ucet ucet1 = new Ucet (50000, 8);

        bool pokracovat = true;
        int zvoleni;

        while (pokracovat)
        {
            Console.WriteLine("Vyber operaci: ");
            Console.WriteLine(" (1) Zobrazit zustatek ");
            Console.WriteLine(" (2) Zobrazit jak dlouho mam ucet ");
            Console.WriteLine(" (3) Vklad ");
            Console.WriteLine(" (4) Vyber ");
            Console.WriteLine(" (5) Konec ");

            zvoleni = int.Parse(Console.ReadLine());

            switch (zvoleni)
            {
                case 1:
                    ucet1.ZobrazZustatek();
                    break;
                case 2:
                    ucet1.ZobrazZalozeni();
                    break;
                case 3:
                    Console.WriteLine("Kolik chces vlozit");
                    double vloz = double.Parse(Console.ReadLine()); 
                    ucet1.Vlozit(vloz);
                    break;
                case 4:
                    Console.WriteLine("Kolik chces vybrat");
                    double vyber = double.Parse(Console.ReadLine());
                    ucet1.Vyber(vyber);
                    break;
                case 5:
                    pokracovat = false;
                    break;
            }
        }
    }
}