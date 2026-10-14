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
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    // Vstup poslední hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    // Vstup kroku
    Console.Write("Zadejte krok řady (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step == 0)
    {
        Console.Write("Zadejte platný krok (celé číslo různé od nuly): ");
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
    Console.Write("Pro opakování programu stiskněte klávesu A. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}