class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej 1. cislo:");
        double prvni_cislo  = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej 2. cislo:");
        double druhy_cislo = double.Parse(Console.ReadLine());
        Console.WriteLine("Zadej operaci (+;-;/;*):");
        char operace = char.Parse(Console.ReadLine());

        double vysledek = 0;

        if(operace == '+') {
            vysledek = prvni_cislo + druhy_cislo;
        }
        if (operace == '-')
        {
            vysledek = prvni_cislo - druhy_cislo;
        }
        if (operace == '/')
        {
            vysledek = prvni_cislo / druhy_cislo;
        }
        if (operace == '*')
        {
            vysledek = prvni_cislo * druhy_cislo;
        }


        Console.WriteLine($"Priklad co jsi zadal: {prvni_cislo}{operace}{druhy_cislo}");
        Console.WriteLine($"Vysledek je: {vysledek}");
    }
}