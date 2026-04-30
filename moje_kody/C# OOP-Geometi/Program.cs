class Program
{
    static void Main()
    {
        Ctverec ctverec1 = new Ctverec(5);

        ctverec1.Obsah();
        ctverec1.Obvod();

        Obdelnik obdelnik1 = new Obdelnik(2, 3);

        obdelnik1.Obsah();
        obdelnik1.Obvod();
    }
}