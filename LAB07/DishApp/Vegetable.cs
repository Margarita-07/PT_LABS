using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public enum VegetableType
    {
        Root,
        Leafy,
        Fruit,
        Bulb
    }

    public class Vegetable : Ingredient
    {
        public VegetableType Type { get; set; }

        public Vegetable(string name, double weight, double calories, double price, VegetableType type)
            : base(name, weight, calories, price)
        {
            Type = type;
        }
    }
}
