string again = "a";

while (again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu A. Následně potvrďte klávesou Enter.");
    again = Console.ReadLine() ?? "";git add .
}