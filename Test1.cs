using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 5;
            int tal2 = 3;
            Console.WriteLine("välj räknesätt!");
            Console.WriteLine("1: Addition ");
            Console.WriteLine("2: Subtraktion ");
            Console.WriteLine("3: Division ");
            Console.WriteLine("4: Multiplikation ");
            int val = int.Parse(Console.ReadLine());
            int resultat = 0;

            if (val == 1)
                resultat = tal1 + tal2;

            else if (val == 2)

                resultat = tal1 - tal2;
            else if (val == 3)

                resultat = tal1 / tal2;
            else if (val == 4)

                resultat = tal1 * tal2;


            Console.Write("Resultatet av beräkningar är: " + resultat);



        }
    }
}
