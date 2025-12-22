using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public interface IDiet
    {
        double RecalculateCalories();
        double RecalculatePrice();
    }
}
