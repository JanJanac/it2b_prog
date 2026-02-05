class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej číslo do kterého chceš hrát:");
        int n= int.Parse(Console.ReadLine());

        int vypis = n;

        for (int i = 1; i <= n; i++)
        {
            vypis = i;
            if (i % 15 == 0) { 
                Console.WriteLine($"FizzBuzz");
            }else if (i % 5 == 0) {
                Console.WriteLine($"Buzz");
            } else if (i % 3 == 0) {
                Console.WriteLine($"Fizz");
            } else {
                Console.WriteLine($" {vypis}");
            }
        }
    }
}