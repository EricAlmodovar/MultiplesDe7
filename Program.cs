internal class Program
{
    //Missatge creat al VS Code
    private static void Main(string[] args)
    {
        //Missatge creat des de GitHub
        Console.Write("Introdueix un valor límit: ");
        string? input = Console.ReadLine();
        int limit = 0;

        if (!int.TryParse(input, out limit))
        {
            Console.WriteLine("Valor no vàlid.");
            return;
        }

        List<int> multiples = Metodes.comptadorMultiples(limit);

        Console.WriteLine("Els múltiples de 7 més petits que " + limit + " són:");
        Console.WriteLine(string.Join(", ", multiples));
        Console.WriteLine("Hi han " + multiples.Count + " nombres múltiples de 7 més petits que " + limit + "."); // missatge nou!!
    }
}

internal class Metodes
{
    public static List<int> comptadorMultiples(int v)
    {
        List<int> multiples = new List<int>();

        for (int i = 1; i < v; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }

        return multiples;
    }
}
