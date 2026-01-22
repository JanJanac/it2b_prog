class Program {
    static void Main() {
        Console.WriteLine("Zadej prvni cislo:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadej druhe cislo:");
        int b = int.Parse(Console.ReadLine());

        int soucet = a + b;
        Console.WriteLine($"Soucet: {soucet}");
    }
}