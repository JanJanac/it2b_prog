class Program
{
    static bool SestrojeniTrojuhelniku(double strana1, double strana2, double strana3)
    {
        return strana1 + strana2 > strana3 && strana2 + strana3 > strana1 && strana3 + strana1 > strana2;
    }
    static void Main()
    {
        Console.Write("Zadej delku 1. strany: ");
        double strana1 = double.Parse(Console.ReadLine());

        Console.Write("Zadej delku 2. strany: ");
        double strana2 = double.Parse(Console.ReadLine());

        Console.Write("Zadej delku 3. strany: ");
        double strana3 = double.Parse(Console.ReadLine());

        
        Console.WriteLine($"Jde trojuhelnik setrojit? {SestrojeniTrojuhelniku(strana1, strana2, strana3)} ");
    }
}