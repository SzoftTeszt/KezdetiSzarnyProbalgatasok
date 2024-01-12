ConsoleKeyInfo betu;
do
{
    var veletlen = new Random();
    int szam = veletlen.Next(1, 100);
    Console.WriteLine("Üdv a számkitalálós játékban!: " + szam);
    Console.WriteLine();
    int tipp = 0;
    int proba = 0;
    do
    {
        Console.WriteLine();
        Console.Write("Kérem a tipped: ");
        tipp = Convert.ToInt32(Console.ReadLine());
        proba++;
        if (tipp < szam) Console.WriteLine("A tipped túl kicsi!");
        else if (tipp > szam) Console.WriteLine("A tipped túl nagy!");

    } while (szam != tipp && proba < 5);

    if (tipp == szam) Console.WriteLine("Kitaláltad!!! Te egy zseni vagy!");
    else Console.WriteLine("Szerintem szellemi fogyatékos lehetsz!");
    Console.WriteLine("Szeretnél még egyet jácccani? (i/n)");
    betu = Console.ReadKey();
    Console.Clear();
} while (betu.Key == ConsoleKey.I);