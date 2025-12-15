using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressionsLab
{
    public class ArithmeticProgression : Progression
    {
        public ArithmeticProgression(double first, double diff)
            : base(first, diff, "Арифметическая прогрессия")
        {
        }

        public override double GetElement(int n)
        {
            return FirstElement + (n - 1) * CommonDifference;
        }

        public override double Sum(int n)
        {
            return n * (2 * FirstElement + (n - 1) * CommonDifference) / 2;
        }
    }
}

