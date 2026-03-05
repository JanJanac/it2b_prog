class Program
{
    static void Main()
    {
        double[] pole = new double[10];

        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Zadej {i + 1}. desetinne cislo: ");
            pole[i] = double.Parse(Console.ReadLine());
        }

        double max = pole.Max();
        double min = pole.Min();

        Console.WriteLine($"Maximum ktere jsi zadal: {max} ");
        Console.WriteLine($"Rozdil mezi maximem a minimem je: {max - min} ");
        
        Array.Sort(pole);

        for (int j = 0; j < 3; j++) {
            Console.WriteLine($"{j + 1}. Nejnizsi hodnota: {pole[j]}");
        }

        double median = (pole[4] + pole[5]) / 2;
        Console.WriteLine($"Median je: {median} ");
    }
}