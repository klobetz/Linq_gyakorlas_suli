using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //készítsünk egy listát amit véletlen számokkal töltünk fel. 
            //a felhasználó álltal kérjük be egy számot és ez legyen a lista hossza
            //ellenőrizzük hogy a megadott érték helyes-e

            var list = new List<int>();
            Console.Write("kérek egy számot: ");
            var valasz = Console.ReadLine();
            int szam;
            while (!int.TryParse(valasz, out szam) )
            {
                Console.Write("Nem jó a megadott érték!\nKérek egy helyes számot!: ");
                valasz = Console.ReadLine();
            }
            var r = new Random();
            for (int i = 0; i < Convert.ToInt32(valasz); i++)
            {
                list.Add(r.Next(1,100));
            }
            //írassuk ki a listát!
            list.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            Console.Write(String.Join(" ", list));


            //a lista első eleme:
            Console.WriteLine();

            Console.WriteLine($"az első listaelem: {list.FirstOrDefault()}");
            //utolsó elem:
            Console.WriteLine($"Az utolsó listaelem:{list.LastOrDefault()}");

            //lista rendezése növekvőbe
            Console.WriteLine("\nrendezett lista");
            list.OrderBy(x => x).ToList().ForEach(x => Console.Write($"{x} "));

            list.Sort();
            Console.WriteLine("\n");
            list.ForEach(x => Console.Write($"{x} "));


            //lista kiíratása fordított sorrendben
            Console.WriteLine("\n");
            list.OrderByDescending(x => x).ToList().ForEach(x => Console.Write($"{x} "));

            //csoportosított lista azaz a számok ne ismétlődjenek.
            Console.WriteLine("\n");
            list.GroupBy(x => x).ToList().ForEach(x => Console.Write($"{x.Key} "));

            //vagy 
            Console.WriteLine("\n");
            list.Distinct().ToList().ForEach(x => Console.Write($"{x} "));

            //összeadás:
            Console.WriteLine();
            Console.WriteLine($"A lista elemeinek az összege: {list.Sum()}");

            //páros számok kiíratása
            Console.WriteLine();
            list.Where(x => x % 2 == 0).ToList().ForEach(í => Console.Write($"{í} "));

            //páratlan számok kiíratása
            Console.WriteLine("\n");
            list.Where(x => x % 2 != 0).ToList().ForEach(í => Console.Write($"{í} "));

            var list2 = new List<int>() {1,5,8,4,7,5,2,1,5,4,54,5,4,8,8,7,4, };

            for

            Console.ReadLine();

        }
    }
}
