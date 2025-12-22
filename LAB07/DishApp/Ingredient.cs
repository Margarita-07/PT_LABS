using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Weight { get; set; } // в граммах
        public double Calories { get; set; } // калорийность на 100г
        public double Price { get; set; } // цена за 100г

        public Ingredient(string name, double weight, double calories, double price)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} ({Weight}g, {Calories * Weight / 100:F1} kcal, {Price * Weight / 100:F2} руб)";
        }
    }
}

