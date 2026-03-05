class Program
{
    static bool Serazene(double[] cisla)
    {
        for (int i = 0; i < cisla.Length - 1; i++) {
            if (cisla[i] > cisla[i + 1]) {
                return false; 
            }
        }
        return true;
    }
    static void Main()
    {
        double[] pole = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Zadej {i + 1}. cislo: ");
            pole[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Je pole sezarene od nejmensiho po nejvetsi? {Serazene(pole)} ");
    }
}