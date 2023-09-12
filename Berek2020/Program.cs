using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Berek2020
{
    internal class Program
    {
        static List<Berek> berek = new List<Berek>();
        static void Main(string[] args)
        {
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            Console.ReadLine();
        }

        private static void feladat7()
        {
            Console.WriteLine("\n7. Feladat");
            foreach (var item in berek.FindAll(z => z.Ber == 0).GroupBy(a => a.Nev).Select(b => new { ok = b.Key, db = b.Count()}))
            {
                if (item.db > 2)
                {
                    Console.WriteLine($"\t{item.ok} : {item.db}");
                }
            }
            Console.WriteLine("Statisztikák: ");
        }

        private static void feladat6()
        {
            Console.WriteLine("\n6. Feladat");
            foreach (var item in berek.Select(a => a.Belepes))
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine("A legtöbbet kereső dolgozó a megadott részlegen: ");
        }

        private static void feladat5()
        {
            Console.WriteLine("\n5. Feladat");
            foreach(Berek item in berek.FindAll(a => a.Equals("beszerzés")))
            {
                Console.WriteLine($"Kérem egy részleg nevét: \t{item.Belepes.ToString()}");
            }
            Console.WriteLine("Kérem egy részleg nevét: ");
        }

        private static void feladat4()
        {
            Console.WriteLine("\n4. Feladat");
            foreach (Berek item in berek.FindAll(a => a.Equals("")))
            {
                Console.WriteLine($"Bérek átlaga: \t{item.Ber.ToString()}. eFT");
            }
            Console.WriteLine($"Bérek átlaga: ");
        }

        private static void feladat3()
        {
            Console.WriteLine("3. Feladat");
            Console.WriteLine($"Dolgozók száma: " + berek.Count());
        }

        private static void adatbeolvas()
        {
            try
            {
                using (StreamReader file = new StreamReader(@"berek2020"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        berek.Add(new Berek(file.ReadLine()));

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
