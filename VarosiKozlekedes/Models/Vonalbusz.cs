using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiKozlekedes.Models
{
    internal class Vonalbusz : Jegyrendszer
    {
        public Vonalbusz() { }
        public Vonalbusz(int alapdij, int tavolsag) : base(alapdij, tavolsag) { }

        public override int ArSzamitas()
        {
            return (Alapdij + 30) * Tavolsag;
        }
    }
}
