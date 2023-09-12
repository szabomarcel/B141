using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- Két szám bekérése és összeadása
            int szamA, szamB; // -- deklalálás
            /*Console.Write("Kérem adja meg  az két számot: ");
            szamA = int.Parse(Console.ReadLine());
            szamB = int.Parse(Console.ReadLine());*/
            Console.Write("Kérem adja meg  az első számot: ");
            szamA = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg  az második számot: ");
            szamB = int.Parse(Console.ReadLine());
            Console.WriteLine("A két szm összege ennyi: " + (szamA + szamB).ToString());
            Console.ReadKey();
        }
    }
}
