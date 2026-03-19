class Program
{
    static void Anomalie(double[] cisla)
    {
        int pocet = 0;

        Console.WriteLine($"Anomalie:");

        for (int i = 1; i < cisla.Length - 1; i++)
        {
            if ( cisla[i-1] < cisla[i] && cisla[i] > cisla[i + 1] || cisla[i - 1] > cisla[i] && cisla[i] < cisla[i + 1])
            {
                pocet++;
                Console.WriteLine($"{cisla[i]}");
            }
        }
        Console.WriteLine($"Pocet anomalii: {pocet}");
    }
    static void Main()
    {
        double[] pole = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Zadej {i + 1}. cislo: ");
            pole[i] = double.Parse(Console.ReadLine());
        }

        Anomalie(pole);
    }
}
