class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 5, 3, 8, 4, 5, 6, 7};
        int cislo;

        Console.WriteLine($"Cisla v listu:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{list[i]}");
        }

        Console.WriteLine("Zadej cislo ktere chces odstranit z listu: ");
        cislo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Aktualni cisla v listu:");
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i] == cislo)
            {
                list.RemoveAt(i);
            } 
            else
            {
                Console.WriteLine($"{list[i]}");
            }
        }
    }
}