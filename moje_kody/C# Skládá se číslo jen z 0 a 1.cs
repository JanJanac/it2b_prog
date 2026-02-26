class Program
{
    static bool SkladaSeZ01(long cislo)
    {
        while (cislo > 0)
        {
            if (cislo % 10 != 0 && cislo % 10 != 1)
            {
                return false; 
            }
            cislo /= 10;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Zadej cislo: ");
        long cislo = long.Parse(Console.ReadLine());
        
        Console.WriteLine($"Sklada se cislo jen z 0 a 1? {SkladaSeZ01(cislo)} ");
    }
}