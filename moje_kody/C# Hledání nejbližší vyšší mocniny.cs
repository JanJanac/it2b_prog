class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej číslo:");
        int n = int.Parse(Console.ReadLine());

        double mocnina = 0;

        for (int i = 0; n > Math.Pow(2, i-1); i++) {
            if (n < Math.Pow(2, i)) {
                mocnina = Math.Pow(2, i);
                Console.WriteLine($"Nejblizsi mocnina cisla {n} je {mocnina}");
            }
        }
    }
}