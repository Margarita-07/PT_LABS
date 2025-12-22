using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public enum MeatType
    {
        Pork,
        Beef,
        Chicken
    }

    public class Meat : Ingredient, IDiet
    {
        public MeatType Type { get; set; }

        public Meat(string name, double weight, double calories, double price, MeatType type)
            : base(name, weight, calories, price)
        {
            Type = type;
            // Пересчитываем калорийность и цену для диетической версии
            RecalculateCalories();
            RecalculatePrice();
        }

        public double RecalculateCalories()
        {
            // Снижаем калорийность на 20% для диетической версии
            Calories *= 0.8;
            return Calories;
        }

        public double RecalculatePrice()
        {
            // Увеличиваем цену на 15% для диетической версии
            Price *= 1.15;
            return Price;
        }
    }
}
