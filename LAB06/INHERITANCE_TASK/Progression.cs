using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ProgressionsLab
{
    public abstract class Progression
    {
        // Свойства
        public double FirstElement { get; protected set; }
        public double CommonDifference { get; protected set; }
        public string ProgressionType { get; protected set; }

        protected Progression(double first, double diff, string type)
        {
            FirstElement = first;
            CommonDifference = diff;
            ProgressionType = type;
        }

        // Получить n-й элемент прогрессии
        public abstract double GetElement(int n);

        // Сумма первых n элементов
        public abstract double Sum(int n);

        // Сумма элементов на интервале [a, b]
        public virtual double Sum(int a, int b)
        {
            if (a <= 0 || b <= 0 || a > b)
                throw new ArgumentException("Некорректный интервал");

            return Sum(b) - Sum(a - 1);
        }

        // Вывод n первых элементов
        public virtual void Print(int n)
        {
            Console.Write($"{ProgressionType}: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{GetElement(i):F2} ");
            }
            Console.WriteLine();
        }
    }
}