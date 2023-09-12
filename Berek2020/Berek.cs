using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class Berek
    {
        string nev; 
        string neme; 
        string resz1eg; 
        int belepes;
        int ber;
        public string Nev { get => nev; set => nev = value; }
        public string Neme { get => neme; set => neme = value; }
        public string Resz1eg { get => resz1eg; set => resz1eg = value; }
        public int Belepes { get => belepes; set => belepes = value; }
        public int Ber { get => ber; set => ber = value; }

        public Berek(string nev, string neme, string resz1eg, int belepes, int ber)
        {
            this.Nev = nev;
            this.Neme = neme;
            this.Resz1eg = resz1eg;
            this.Belepes = belepes;
            this.Ber = ber;
        }
        public Berek(string beolvas) 
        {
            string[] strings = beolvas.Split(';');
            this.Nev = strings[0];
            this.Neme = strings[1];
            this.Resz1eg = strings[2];
            this.Belepes = int.Parse(strings[3]);
            this.Ber = int.Parse(strings[4]);
        }
    }
}
