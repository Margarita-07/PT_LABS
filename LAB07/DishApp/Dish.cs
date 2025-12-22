using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishApp
{
    public class Dish
    {
        public List<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();

        public void AddToDish(Ingredient ingredient)
        {
            // Проверка: нельзя одновременно иметь рыбу и мясо
            bool hasMeat = Ingredients.Any(i => i is Meat);
            bool hasFish = Ingredients.Any(i => i is Fish);

            if ((hasMeat && ingredient is Fish) || (hasFish && ingredient is Meat))
            {
                throw new InvalidOperationException("Нельзя добавить рыбу и мясо в одно блюдо!");
            }

            // Проверка: нельзя иметь соусы разных типов
            if (ingredient is Sauce newSauce)
            {
                var existingSauces = Ingredients.OfType<Sauce>().ToList();
                if (existingSauces.Any() && existingSauces.Any(s => s.Type != newSauce.Type))
                {
                    throw new InvalidOperationException("Нельзя добавить соусы разных типов в одно блюдо!");
                }
            }

            Ingredients.Add(ingredient);
            Console.WriteLine($"Добавлен ингредиент: {ingredient.Name}");
        }

        public double TotalCalories()
        {
            return Ingredients.Sum(i => i.Calories * i.Weight / 100);
        }

        public double TotalCost()
        {
            return Ingredients.Sum(i => i.Price * i.Weight / 100);
        }

        public override string ToString()
        {
            if (Ingredients.Count == 0)
                return "Блюдо пустое";

            var result = new System.Text.StringBuilder();
            result.AppendLine("Состав блюда:");
            foreach (var ingredient in Ingredients)
            {
                result.AppendLine($"  - {ingredient}");
            }
            result.AppendLine($"Итого: {TotalCalories():F1} ккал, {TotalCost():F2} руб");
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Dish other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return TotalCost().GetHashCode() ^ TotalCalories().GetHashCode();
        }

        public static bool operator ==(Dish d1, Dish d2)
        {
            if (ReferenceEquals(d1, d2)) return true;
            if (d1 is null || d2 is null) return false;

            double cost1 = d1.TotalCost();
            double cost2 = d2.TotalCost();

            if (Math.Abs(cost1 - cost2) < 0.01) // сравнение с точностью до копеек
            {
                return Math.Abs(d1.TotalCalories() - d2.TotalCalories()) < 0.1;
            }
            return cost1 == cost2;
        }

        public static bool operator !=(Dish d1, Dish d2)
        {
            return !(d1 == d2);
        }
    }
}
