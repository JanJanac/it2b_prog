class Program
{
    static bool Kladne (double[] cisla)
    {
        Array.Sort(cisla);
        if (cisla[0] < 0)
        {
            return false;
        }else
        {
            return true;
        }
    }
    static void Main()
    {
        double[] pole = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Zadej {i + 1}. cislo: ");
            pole[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Jsou vsechna cisla kladne? {Kladne(pole)} ");
    }
}