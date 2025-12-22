using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;



namespace DishApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Создание первого блюда (Мясное) ===");
            var dish1 = new Dish();

            try
            {
                dish1.AddToDish(new Meat("Куриная грудка", 200, 165, 120, MeatType.Chicken));
                dish1.AddToDish(new Vegetable("Брокколи", 150, 34, 80, VegetableType.Fruit));
                dish1.AddToDish(new Vegetable("Морковь", 100, 41, 40, VegetableType.Root));
                dish1.AddToDish(new Spice("Чеснок", 10, 149, 30, SpiceType.Bulb));
                dish1.AddToDish(new Sauce("Оливковое масло", 30, 884, 200, SauceType.Oil));

                Console.WriteLine("\n" + dish1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании блюда 1: {ex.Message}");
            }

            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("=== Создание второго блюда (Рыбное) ===");
            var dish2 = new Dish();

            try
            {
                dish2.AddToDish(new Fish("Лосось", 180, 208, 250, FishType.Salmon));
                dish2.AddToDish(new Vegetable("Шпинат", 120, 23, 60, VegetableType.Leafy));
                dish2.AddToDish(new Vegetable("Помидор", 100, 18, 50, VegetableType.Fruit));
                dish2.AddToDish(new Spice("Укроп", 5, 43, 20, SpiceType.Herb));
                dish2.AddToDish(new Sauce("Лимонный соус", 25, 30, 90, SauceType.Oil));

                Console.WriteLine("\n" + dish2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании блюда 2: {ex.Message}");
            }

            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("=== Тестирование операторов сравнения ===");

            Console.WriteLine($"Блюдо 1 == Блюдо 2: {dish1 == dish2}");
            Console.WriteLine($"Блюдо 1 != Блюдо 2: {dish1 != dish2}");

            // Создадим копию блюда для тестирования равенства
            var dish3 = new Dish();
            try
            {
                dish3.AddToDish(new Meat("Куриная грудка", 200, 165, 120, MeatType.Chicken));
                dish3.AddToDish(new Vegetable("Брокколи", 150, 34, 80, VegetableType.Fruit));
                dish3.AddToDish(new Vegetable("Морковь", 100, 41, 40, VegetableType.Root));
                dish3.AddToDish(new Spice("Чеснок", 10, 149, 30, SpiceType.Bulb));
                dish3.AddToDish(new Sauce("Оливковое масло", 30, 884, 200, SauceType.Oil));

                Console.WriteLine($"Блюдо 1 == Блюдо 3: {dish1 == dish3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании блюда 3: {ex.Message}");
            }

            Console.WriteLine("\n=== Тестирование ограничений ===");

            // Попытка добавить рыбу в мясное блюдо
            try
            {
                dish1.AddToDish(new Fish("Тунец", 150, 184, 220, FishType.Tuna));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ожидалась ошибка: {ex.Message}");
            }

            // Попытка добавить другой тип соуса
            try
            {
                dish2.AddToDish(new Sauce("Сливочный соус", 30, 350, 120, SauceType.Cream));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ожидалась ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}