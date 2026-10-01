using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiKozlekedes.Models
{
    internal class Jegyrendszer
    {
        public int Alapdij { get; set; }
        public int Tavolsag { get; set; }

        public Jegyrendszer() { }

        public Jegyrendszer(int alapdij, int tavolsag)
        {
            Alapdij = alapdij;
            Tavolsag = tavolsag;
        }

        public virtual int ArSzamitas()
        {
            return 0;
        }
    }
}
