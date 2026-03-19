class Program
{

    static void Main()
    {
        string login = "Marek";
        string heslo = "123456789";

        Console.WriteLine($"Zadej login: ");
        string tvujlogin = Console.ReadLine();

        if (login != tvujlogin)
        {
            Console.WriteLine($"Tvuj login je spatne");
            return;
        }
        
        Console.WriteLine($"Zadej heslo: ");
        string tvojeheslo = Console.ReadLine();

        if (heslo != tvojeheslo)
        {
            Console.WriteLine($"Tvoje heslo je spatne");
            return;
        }
        else
        {
            Console.WriteLine("Tajna zprava: Marek smrdi");
        }
    }
}