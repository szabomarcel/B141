using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    internal class Kor : Sikidomok
    {
        double sugar;
        double atmero;

        public double Sugar { get => sugar; }
        public double Atmero { get => atmero; }

        public Kor(double sugar) : base("Kör")
        {
            this.sugar = sugar;
            this.atmero = 2 * sugar;
        }
        public override double Kerulet()
        {
            return 2 * sugar * Math.PI; 
        }
        public override double Terulet()
        {
            return sugar * sugar * Math.PI;
        }
    }
}
