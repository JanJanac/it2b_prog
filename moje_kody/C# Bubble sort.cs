class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 5, 2, 9, 1, 6 };

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Seřazený list:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write($"{list[i]}, ");
        }
    }
}