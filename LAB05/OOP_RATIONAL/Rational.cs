using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RATIONAL
{
    public class Rational
    {
        public int Numerator { get; set; }

        private int denominator;
        private int Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator should not be = 0");
                }
                this.denominator = value;
            }
        }
        public int Denominator { get; set; }

        public Rational( int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Rational (int numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }

        public override string ToString()
        {
            return $"Rational: {Numerator} / {Denominator}";
        }
    }
    
}
