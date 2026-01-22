class Program {
    static void Main() {
        Console.WriteLine("Pocet hlasu pro kandidata X:");
        int pocet_hlasu_X = int.Parse(Console.ReadLine());
        Console.WriteLine("Pocet hlasu pro kandidata Y:");
        int pocet_hlasu_Y = int.Parse(Console.ReadLine());

        double soucet_hlasu = pocet_hlasu_X + pocet_hlasu_Y;
        double jeden_hlas = 100 / soucet_hlasu;

        Console.WriteLine($"Kandidat X ma: {jeden_hlas * pocet_hlasu_X}% hlasu");
        Console.WriteLine($"Kandidat Y ma: {jeden_hlas * pocet_hlasu_Y}% hlasu");
    }
}