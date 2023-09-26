using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    internal class Negyzet : Sikidomok
    {
        double oldal;

        public Negyzet(double oldal) : base("Négyzet")
        {
            this.oldal = oldal;
        }

        public double Oldal { get => oldal;}

        public override double Kerulet()
        {
            return 4 * oldal;
        }
        public override double Terulet()
        {
            return oldal * oldal;
        }
    }
}
