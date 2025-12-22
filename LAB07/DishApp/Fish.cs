using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public enum FishType
    {
        Salmon,
        Tuna,
        Cod,
        Trout
    }

    public class Fish : Ingredient, IDiet
    {
        public FishType Type { get; set; }

        public Fish(string name, double weight, double calories, double price, FishType type)
            : base(name, weight, calories, price)
        {
            Type = type;
            // Пересчитываем калорийность и цену для диетической версии
            RecalculateCalories();
            RecalculatePrice();
        }

        public double RecalculateCalories()
        {
            // Снижаем калорийность на 15% для диетической версии
            Calories *= 0.85;
            return Calories;
        }

        public double RecalculatePrice()
        {
            // Увеличиваем цену на 20% для диетической версии
            Price *= 1.20;
            return Price;
        }
    }
}
