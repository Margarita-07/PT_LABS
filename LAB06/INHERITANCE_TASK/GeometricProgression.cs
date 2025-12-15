using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressionsLab
{
    public class GeometricProgression : Progression
    {
        // check if ratio = 0. esli da - generate exception i vyvedi soobshenie ob oshybke
        public GeometricProgression(double first, double ratio)
            : base(first, ratio, "Геометрическая прогрессия")
        {
        }

        public override double GetElement(int n)
        {
            return FirstElement * Math.Pow(CommonDifference, n - 1);
        }

        public override double Sum(int n)
        {
            if (CommonDifference == 1)
                return FirstElement * n;

            return FirstElement * (1 - Math.Pow(CommonDifference, n)) /
                   (1 - CommonDifference);
        }
    }
}
