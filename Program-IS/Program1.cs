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


    Console.Write("Pro opakování programu stiskněte klávesu A. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}