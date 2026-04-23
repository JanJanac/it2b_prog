class Program
{
    static void Main()
    {
        Student Borivoj = new Student("Borivoj", 67, "IT69");

        Console.WriteLine("Jmeno: " + Borivoj.Jmeno);

        Borivoj.PridatZnamku(6);
        Borivoj.PridatZnamku(7);

        Borivoj.VypisZnamky();

        Student Patrick = new Student("Patick", 15, "IT-1A");
    }
    
}
