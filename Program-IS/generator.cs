cshusing System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Zadej pocet cisel: ");
        int pocet = int.Parse(Console.ReadLine());

        if (pocet <= 0)
        {
            Console.WriteLine("Pocet musi byt vetsi nez 0!");
            return;
        }

        Console.Write("Zadej dolni mez (mensi cislo): ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Zadej horni mez (vetsi cislo): ");
        int max = int.Parse(Console.ReadLine());

        if (min >= max)
        {
            Console.WriteLine("Horni mez musi byt vetsi nez dolni mez!");
            return;
        }

        int[] cisla = new int[pocet];

        int kladna = 0, zaporna = 0, nulova = 0;
        int suda = 0, licha = 0;

        for (int i = 0; i < pocet; i++)
        {
            cisla[i] = rnd.Next(min, max + 1);
            Console.Write(cisla[i] + " ");

            if (cisla[i] > 0) kladna++;
            else if (cisla[i] < 0) zaporna++;
            else nulova++;

            if (cisla[i] % 2 == 0) suda++;
            else licha++;
        }

        Console.WriteLine("\n\nKladna cisla: " + kladna);
        Console.WriteLine("Zaporna cisla: " + zaporna);
        Console.WriteLine("Nulova cisla: " + nulova);
        Console.WriteLine("Suda cisla: " + suda);
        Console.WriteLine("Licha cisla: " + licha);
    }
}