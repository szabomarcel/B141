using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    internal class Haromszog : Sikidomok
    {
        double aoldal;
        double boldal;
        double coldal;

        public Haromszog(double aoldal, double boldal, double coldal) : base("Háromszög")
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
        }

        public double Aoldal { get => aoldal; }
        public double Boldal { get => boldal; }
        public double Coldal { get => coldal; }

        public override double Kerulet()
        {
            return aoldal * boldal * coldal;
        }
        public override double Terulet()
        {
            return aoldal + boldal + coldal;
        }
    }
}
