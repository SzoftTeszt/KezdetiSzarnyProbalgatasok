double a, b, c;

Console.WriteLine("Add meg a háromszög első oldalát (cm): ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add meg a háromszög második oldalát (cm): ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Add meg a háromszög harmadik oldalát (cm): ");
c = Convert.ToDouble(Console.ReadLine());

if ((a + b) > c && (b + c) > a && (a + c) > b)
{
    double atfogo=0, bef1=0, bef2=0;
    Console.Write("A 3szög tök okés!");
    if ((a > b) && (a > c)) { atfogo = a; bef1 = b; bef2 = c; }
    if ((b > a) && (b > c)) { atfogo = b; bef1 = a; bef2 = c; }
    if ((c > b) && (c > a)) { atfogo = c; bef1 = a; bef2 = b; }

  

    if ( (atfogo!=0) && (atfogo*atfogo == Math.Pow(bef1,2)+Math.Pow(bef2,2)) )
        Console.Write(" És még derékszögű is!");
}
else {
    Console.WriteLine("Ez a 3szög meghibásodott!");
}
