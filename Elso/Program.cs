using System;
namespace Elso
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Jáger Attila");
            //Console.Write("Jáger Attila");
            //Console.Write("Jáger Attila");
            
            //Console.Write("Írd be a neved: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Üdv Kedves "+userName+"!");

            Console.Write("Adj meg egy számot: ");
            int szam = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("A {0} \"kétszerese\" {1}",szam, 2*szam);
            Console.WriteLine( "A "+szam+" kétszerese "+(2*szam) );
            //if (szam>100)
                if (szam>100 && szam % 2 == 0)
                {
                    Console.WriteLine("Páros");
                }
                else {
                    Console.WriteLine("Páratlan");
                }

            int i = 0;
            for (; ; ) {
                Console.Write('*');
                i=i+2;
                if (i > 10) break;
            }

            Console.WriteLine();

            i = 0;
            while (i<10) {
                Console.Write('*');
                i++;
            }

            Console.WriteLine();
            i = 0;
            do {
                Console.Write('*');
                i++;
            } while (i<10);

            Console.ReadKey();
        }
    }
}