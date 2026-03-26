class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej email:");
        string email = Console.ReadLine();

        int pocetAt = 0;
        for (int i = 0; i < email.Length; i++) {
            if (email[i] == '@') {
                pocetAt++;
            }
        }

        if (pocetAt != 1) {
            Console.WriteLine("Email není validní: musí obsahovat právě jeden '@'");
            return;
        }

        if (email[0] == '@') {
            Console.WriteLine("Email není validní: '@' nemůže být první znak");
            return;
        }

        int poziceAt = email.IndexOf('@');

        bool teckaZaAt = false;
        for (int i = poziceAt + 1; i < email.Length; i++) {
            if (email[i] == '.') {
                teckaZaAt = true;
                break;
            }
        }

        if (!teckaZaAt) {
            Console.WriteLine("Email není validní: za '@' musí být alespoň jedna tečka");
            return;
        }

        Console.WriteLine("Email je validní!");

    }
}