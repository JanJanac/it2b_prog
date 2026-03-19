class Program
{
    static void Main()
    {
        Console.WriteLine($"Zadej slovo: ");
        string slovo = Console.ReadLine();
        
        Console.WriteLine($"Zadej znak k cenzure: ");
        char cenzura = Console.ReadLine()[0];

        foreach (char znak in slovo)
        {
           if (znak == cenzura)
           {
                Console.Write($"*");
           } 
           else
           {
                Console.Write(znak);
           }
        }
    }
}