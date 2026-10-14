string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("*****************Vypiš Řady*****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************Jakub Kovačík****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");

    // Vstup počáteční hodnoty
    Console.Write("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    // Vstup poslední hodnoty
    Console.Write("Zadejte poslední číslo řady: ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    // Vstup kroku
    Console.Write("Zadejte krok řady: ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step == 0)
    {
        Console.Write("Zadejte celé číslo různé od nuly: ");
    }

    // Výpis číselné řady
    if (step > 0)
    {
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        for (int i = first; i >= last; i += step)
        {
            Console.WriteLine(i);
        }
    }

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu A. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}