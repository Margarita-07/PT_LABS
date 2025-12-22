using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public enum SauceType
    {
        Tomato,
        Cream,
        Soy,
        Oil,
        Mustard
    }

    public class Sauce : Ingredient, IDiet
    {
        public SauceType Type { get; set; }

        public Sauce(string name, double weight, double calories, double price, SauceType type)
            : base(name, weight, calories, price)
        {
            Type = type;
            // Пересчитываем калорийность и цену для диетической версии
            RecalculateCalories();
            RecalculatePrice();
        }

        public double RecalculateCalories()
        {
            // Снижаем калорийность на 30% для диетической версии
            Calories *= 0.7;
            return Calories;
        }

        public double RecalculatePrice()
        {
            // Увеличиваем цену на 25% для диетической версии
            Price *= 1.25;
            return Price;
        }
    }
}
