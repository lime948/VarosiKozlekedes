using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiKozlekedes.Models
{
    internal class Gyorsvasut : Jegyrendszer
    {
        public Gyorsvasut() { }
        public Gyorsvasut(int alapdij, int tavolsag) : base(alapdij, tavolsag) { }
        public override int ArSzamitas()
        {
            return (Alapdij * 2 + 50) * Tavolsag;
        }
    }
}
