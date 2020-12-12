using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    public class Fraction
    {
        protected long Numer;
        protected long Denom;
        public Fraction(long numer, long denom = 1)
        {
            Numer = numer;
            Denom = denom;
        }
      
    }
}
