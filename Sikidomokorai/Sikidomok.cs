using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomokorai
{
    abstract class Sikidomok
    {        
        public string tipus;
        protected Sikidomok(string tipus)
        {
            this.tipus = tipus;
        }
        public abstract double Kerulet();
        public abstract double Terulet();
        public override string ToString()
        {
            return tipus;
        }
    }
}
