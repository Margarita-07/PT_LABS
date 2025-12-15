using System;
namespace ProgressionsLab
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Массив из 10 прогрессий разных типов
            Progression[] progressions = new Progression[10]
            {
                new ArithmeticProgression(1, 2),
                new ArithmeticProgression(5, 3),
                new ArithmeticProgression(10, -1),
                new ArithmeticProgression(2, 0.5),

                new GeometricProgression(1, 2),
                new GeometricProgression(3, 0.5),
                new GeometricProgression(2, 3),
                
                new GeometricProgression(5, 1),

                new ArithmeticProgression(7, 7),
                new GeometricProgression(1, 0)
            };

            // 1) Сумма 10-х элементов всех прогрессий
            double sum10th = 0;

            foreach (var p in progressions)
            {
                sum10th += p.GetElement(10);
            }

            Console.WriteLine($"Сумма 10-х элементов всех прогрессий: {sum10th:F2}\n");

            // 2) Прогрессия с максимальной суммой первых 5 элементов
            Progression best = null;
            double maxSum = double.MinValue;

            foreach (var p in progressions)
            {
                double s = p.Sum(5);
                if (s > maxSum)
                {
                    maxSum = s;
                    best = p;
                }
            }

            Console.WriteLine("Прогрессия с максимальной суммой первых 5 элементов:");
            Console.WriteLine($"{best.ProgressionType}, сумма = {maxSum:F2}\n");

            // 3) Вывод первых 5 элементов всех прогрессий
            Console.WriteLine("Первые 5 элементов каждой прогрессии:\n");

            foreach (var p in progressions)
            {
                p.Print(5);
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}