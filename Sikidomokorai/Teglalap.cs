using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    internal class Teglalap : Sikidomok
    {
        readonly double rovidebboldal;
        readonly double hosszabboldal;

        public Teglalap(double rovidebboldal, double hosszabboldal) : base("Téglalap")
        {
            this.rovidebboldal = rovidebboldal;
            this.hosszabboldal = hosszabboldal;
        }

        public double Rovidebboldal { get => rovidebboldal; }
        public double Hosszabboldal { get => hosszabboldal; }

        public override double Kerulet()
        {
            return (2 * Rovidebboldal) + (2 * Hosszabboldal);
        }
        public override double Terulet()
        {
            return (Rovidebboldal + Hosszabboldal) / 2;
        }
    }
}
