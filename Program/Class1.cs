using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Program
{
    public class Fraction
    {
        protected long Numer;
        protected long Denom;
        protected long Result;
        public Fraction(long numer, long denom = 1)
        {
            this.Numer = numer;
            this.Denom = denom;

        }
        public Fraction(string fraction)
        {
            Regex regex = new Regex(@"(\d+)\/(\d+)");
            Match match = regex.Match(fraction);
            Numer = long.Parse(match.Groups[1].Value.ToString());
            Denom = long.Parse(match.Groups[2].Value.ToString());
        }
        public override string ToString()
        {
            return $"{Numer}/{Denom}";
        }
        public static Fraction operator ++(Fraction one)
        {
            return (new Fraction(one.Numer + 1, one.Denom + 1));
        }
        public static Fraction operator --(Fraction one)
        {
            return (new Fraction(one.Numer - 1, one.Denom - 1));
        }
        public static Fraction operator +(Fraction one, Fraction two)
        {
            return (new Fraction ( one.Numer + two.Denom ));
        }
        public static Fraction operator -(Fraction one, Fraction two)
        {
            return (new Fraction(one.Numer - two.Denom));
        }
        public static Fraction operator *(Fraction one, Fraction two)
        {
            return (new Fraction(one.Numer * two.Denom));
        }
        public static Fraction operator /(Fraction one, Fraction two)
        {
            return (new Fraction(one.Numer / two.Denom));
        }
        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                if (((Fraction)obj).Numer == this.Numer && ((Fraction)obj).Denom == this.Denom)
                    return true;
            }
            return false;
        }
        public static bool operator >(Fraction one, Fraction two)
        {
            return one.Numer > two.Denom;
        }
        public static bool operator <(Fraction one, Fraction two)
        {
            return one.Numer < two.Denom;
        }
        public static bool operator >=(Fraction one, Fraction two)
        {
            return one.Numer >= two.Denom;
        }
        public static bool operator <=(Fraction one, Fraction two)
        {
            return one.Numer <= two.Denom;
        }
        public static bool operator ==(Fraction one, Fraction two)
        {
            return one.Equals(two);
        }
        public static bool operator !=(Fraction one, Fraction two)
        {
            return !one.Equals(two);
        }

    }
}
