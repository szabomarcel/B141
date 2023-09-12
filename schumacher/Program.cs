using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace schumacher
{
    internal class Program
    {
        static List<Scumi> adatok = new List<Scumi>(); //--dinamikus lista
        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladatok3();
            //feladatok4();
            //feladatok5();
            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladatok3()
        {
            Console.WriteLine("3. feladat");
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
