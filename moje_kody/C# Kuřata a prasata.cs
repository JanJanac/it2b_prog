class Program {
    static void Main() {
        Console.WriteLine("Jaky je celkovy pocet nohou:");
        int celkovy_pocet_nohou = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej kolik je na farme prasat:");
        int prasata = int.Parse(Console.ReadLine());

        int kurata = ((celkovy_pocet_nohou - (prasata * 4)) / 2);

        Console.WriteLine($"Kurat je: {kurata}");
    }
}
