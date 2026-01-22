class Program {
    static void Main() {
        Console.WriteLine("Pocet prednasek:");
        int pocet_prednasek = int.Parse(Console.ReadLine());
        Console.WriteLine("Pocet seminaru:");
        int pocet_seminaru = int.Parse(Console.ReadLine());
        Console.WriteLine("Hodinova mzda:");
        int hodinova_mzda = int.Parse(Console.ReadLine());

        int vyplata = ((2 * pocet_prednasek + 1 * pocet_seminaru) * hodinova_mzda);

        Console.WriteLine($"Vyplata je: {vyplata}");
    }
}