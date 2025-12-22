using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public enum SpiceType
    {
        Herb,
        Seed,
        Root,
        Flower,
        Bulb
    }

    public class Spice : Ingredient
    {
        public SpiceType Type { get; set; }

        public Spice(string name, double weight, double calories, double price, SpiceType type)
            : base(name, weight, calories, price)
        {
            Type = type;
        }
    }
}
