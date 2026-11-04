string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("****** Součet a součin cifer ******");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
    {
        Console.Write("Prosím zadejte kladné číslo: ");
    }

    int sum = 0;
    int product = 1;

    string text = Math.Abs((long)number).ToString();

    foreach (char znak in text)
    {
        int digit = int.Parse(znak.ToString());

        sum += digit;
        product *= digit;
    }

    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine($"Původní číslo: {number}");
    Console.WriteLine($"Součet číslic: {sum}");
    Console.WriteLine($"Součin číslic: {product}");
    Console.WriteLine("===================================");

    Console.WriteLine();
    Console.Write("Pro opakování zadejte 'a': ");
    again = Console.ReadLine() ?? "";
}