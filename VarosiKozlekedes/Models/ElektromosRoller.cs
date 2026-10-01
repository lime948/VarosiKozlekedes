using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiKozlekedes.Models
{
    internal class ElektromosRoller : Jegyrendszer
    {
        public ElektromosRoller() { }
        public ElektromosRoller(int alapdij, int tavolsag) : base(alapdij, tavolsag) { }
        public override int ArSzamitas()
        {
            return Tavolsag * 120;
        }
    }
}
