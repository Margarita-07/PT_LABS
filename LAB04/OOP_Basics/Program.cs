using System;
using OOP_Basics;

namespace OOP_SAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student s1 = new Student("Жилевская Елизавета", "ElE241.1", -9.2);

                s1.GPA = -4;

                s1.PrintInfo();  // Ожидается Excellent = true

                Student s2 = new Student("Адолевская Александра", "ElE241.1", 7.5);
                s2.PrintInfo();  // Ожидается Excellent = false

                Student s3 = new Student("Сержан Диана", "ElE241.2", 9.0);
                s3.PrintInfo();  // Ожидается Excellent = true

                // Попытка установить некорректный GPA
                Student s4 = new Student("Зенюк Виктория", "ElE241.1", 12.0);
                s4.PrintInfo(); // Выбросит исключение
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка при создании студента: {ex.Message}");
            }

            // Проверка свойства записи для GPA после создания
            Student s5 = new Student("Зданович Маргарита", "ElE241.1", 8.0);
            s5.PrintInfo();
            try
            {
                s5.GPA = -1; // должно сгенерировать исключение
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка при установке GPA: {ex.Message}");
            }
        }
    }
}
