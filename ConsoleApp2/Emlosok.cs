using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Emlosok
    {
        //tulajdonságok -> viselkedés
        public string Nev;
        public string faj;
        public int labszam;
        public double suly;
        public string nem;
        string hang;

        //Hang megadás
        public String getHangotAd()
        {
            return hang;
        }

        public void setHangotAd(string hang)
        {
            this.hang = hang;
        }
        public String Halad()
        {
            return "elöre";
        }
        public override string ToString()
        {
            return this.Nev;
        }
        // Konstruktor létrehozása. 
        public Emlosok(string nev, string faj, int labszam, double suly, string nem, string hang)
        {
            this.Nev = nev;
            this.faj = faj;
            this.labszam = labszam;
            this.suly = suly;
            this.nem = nem;
            this.hang = hang;
        }
    }
}
