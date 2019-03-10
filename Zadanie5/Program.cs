using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Zadanie5
{
    class Program
    {
 

        static void Main(string[] args)
        {
            string wyraz, wyraz_odwrocony = "";

            // wczytanie wyrazu
            Console.WriteLine("Podaj wyraz:");
            wyraz = Console.ReadLine();

            // eliminacja spacji, cyfr i innych znakow

            Regex rgx = new Regex("[^a-zA-Z]");
            string nowy = rgx.Replace(wyraz, "");

            // odwracanie wyrazu

            for (int i = nowy.Length - 1; i >= 0; i--)
            {
                wyraz_odwrocony += nowy[i];
            }
            //porownanie podanego wyrazu z odwroconym
            if (nowy == wyraz_odwrocony)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}
