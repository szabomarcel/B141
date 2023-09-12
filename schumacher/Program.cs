using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace schumacher
{
    internal class Program
    {
        static List<Scumi> adatok = new List<Scumi>(); //--dinamikus lista
        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladatok3();
            feladatok4();
            feladatok5();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladatok5()
        {
            Console.WriteLine("5. Feladat");
            foreach(var item in adatok.FindAll(z => z.Position == 0).GroupBy(a => a.Status).Select(b => new { ok = b.Key, db = b.Count()})) 
            {
                if (item.db > 2)
                {
                    Console.WriteLine($"\t{item.ok} : {item.db}");
                }
            }
        }

        private static void feladatok4()
        {
            Console.WriteLine("4. Feladat Magyar nagydíj helyzései");
            foreach (Scumi item in adatok.FindAll(a => a.Grandprix.Equals("Hungarian Grand Prix") && a.Position > 0)) 
            {
                Console.WriteLine($"\t{item.Date.ToShortDateString()} : {item.Position}. hely");
            }
        }

        private static void feladatok3()
        {
            Console.WriteLine("3. Feladat");
            Console.WriteLine($"\t{adatok.Count} sort olvastat");
        }

        private static void adatokBeolvasasa()
        {
            try
            {
                using (StreamReader file = new StreamReader(@"schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatok.Add(new Scumi(file.ReadLine()));

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
