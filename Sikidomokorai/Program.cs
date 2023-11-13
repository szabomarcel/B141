using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidomok> sikidomos = new List<Sikidomok>();
            sikidomos.Add(new Kor(10));
            sikidomos.Add(new Kor(20));
            sikidomos.Add(new Negyzet(12));
            sikidomos.Add(new Teglalap(13, 2));
            sikidomos.Add(new Haromszog(1, 2, 3));
            foreach (var item in sikidomos)
            {
                if(item.GetType().Equals(typeof(Kor)))
                {
                    Kor kor = (Kor)item; // -- Csak így juthatunk az egyedi adathoz, a sugérhoz
                    //Console.WriteLine($"\nAz 1. elem {item.GetType()} - {item}");
                    Console.WriteLine($"A kör Terület: {kor.Terulet()} - Kerület: {kor.Kerulet()} - sugara: {kor.Sugar}");
                    kor.Kisebb();
                    kor.Nagyobb();
                    kor.Vonalvastagsag();
                }
                else if (item.GetType().Equals(typeof(Negyzet)))
                {
                    Negyzet negyzet = (Negyzet)item;
                    Console.WriteLine($"A négyzet Terület: {negyzet.Terulet()} - Kerület: {negyzet.Kerulet()}");
                }
                else if (item.GetType().Equals(typeof(Teglalap)))
                {
                    Teglalap teglalap = (Teglalap)item;
                    Console.WriteLine($"A téglalap Terület: {teglalap.Terulet()} - Kerület: {teglalap.Kerulet()}");
                }
                else if (item.GetType().Equals(typeof(Haromszog)))
                {
                    Haromszog haromszog= (Haromszog)item;
                    Console.WriteLine($"A háromszög Terület: {haromszog.Terulet()} - Kerület: {haromszog.Kerulet()}");
                }
            }
            Console.ReadLine();
        }
    }
}
