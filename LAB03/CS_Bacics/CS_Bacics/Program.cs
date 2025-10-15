
using System;

class Program
{
    static void Main()
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.Clear();
            Console.WriteLine("=== Лабораторная работа №3 ===");
            Console.WriteLine("Выберите блок задач:");
            Console.WriteLine("1 - Блок 1");
            Console.WriteLine("2 - Блок 2");
            Console.WriteLine("3 - Блок 3");
            Console.WriteLine("4 - Блок 4");
            Console.WriteLine("5 - Блок 5");
            Console.WriteLine("0 - Выход из программы");
            Console.Write("Введите номер блока: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": ShowBlock1Menu(); break;
                case "2": ShowBlock2Menu(); break;
                case "3": ShowBlock3Menu(); break;
                case "4": ShowBlock4Menu(); break;
                case "5": ShowBlock5Menu(); break;
                case "0": exitProgram = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }
        }
        Console.WriteLine("Выход из программы. До свидания!");
    }

    static void ShowBlock1Menu()
    {
        bool exitBlock = false;
        while (!exitBlock)
        {
            Console.Clear();
            Console.WriteLine("=== Блок 1: Переменные и операторы ===");
            Console.WriteLine("1 - Задача 2: Индекс массы тела (ИМТ)");
            Console.WriteLine("2 - Задача 4: Перевод времени");
            Console.WriteLine("3 - Задача 6: Цена со скидкой");
            Console.WriteLine("0 - Вернуться в главное меню");
            Console.Write("Введите номер задачи: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task1_2(); break;
                case "2": Task1_4(); break;
                case "3": Task1_6(); break;
                case "0": exitBlock = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }

            if (!exitBlock)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    static void ShowBlock2Menu()
    {
        bool exitBlock = false;
        while (!exitBlock)
        {
            Console.Clear();
            Console.WriteLine("=== Блок 2: Условные операторы if-else, switch ===");
            Console.WriteLine("1 - Задача 2: Тип треугольника");
            Console.WriteLine("2 - Задача 4: Оценка по числу");
            Console.WriteLine("3 - Задача 6: Конвертация валют");
            Console.WriteLine("0 - Назад в главное меню");
            Console.Write("Введите номер задачи: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task2_2(); break;
                case "2": Task2_4(); break;
                case "3": Task2_6(); break;
                case "0": exitBlock = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }

            if (!exitBlock)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    static void ShowBlock3Menu()
    {
        bool exitBlock = false;
        while (!exitBlock)
        {
            Console.Clear();
            Console.WriteLine("=== Блок 3: Циклы while, do-while, for ===");
            Console.WriteLine("1 - Задача 2: Переворот числа");
            Console.WriteLine("2 - Задача 4: Максимальное нечётное число");
            Console.WriteLine("3 - Задача 6: Арифметическая прогрессия");
            Console.WriteLine("0 - Назад в главное меню");
            Console.Write("Введите номер задачи: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task3_2(); break;
                case "2": Task3_4(); break;
                case "3": Task3_6(); break;
                case "0": exitBlock = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }

            if (!exitBlock)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    static void ShowBlock4Menu()
    {
        bool exitBlock = false;
        while (!exitBlock)
        {
            Console.Clear();
            Console.WriteLine("=== Блок 4: Массивы ===");
            Console.WriteLine("1 - Задача 2: Второй по величине элемент");
            Console.WriteLine("2 - Задача 4: Чётные элементы в столбцах");
            Console.WriteLine("3 - Задача 6: Диагонали матрицы");
            Console.WriteLine("0 - Назад в главное меню");
            Console.Write("Введите номер задачи: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task4_2(); break;
                case "2": Task4_4(); break;
                case "3": Task4_6(); break;
                case "0": exitBlock = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }

            if (!exitBlock)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    static void ShowBlock5Menu()
    {
        bool exitBlock = false;
        while (!exitBlock)
        {
            Console.Clear();
            Console.WriteLine("=== Блок 5: Функции ===");
            Console.WriteLine("1 - Задача 2: Генерация массива");
            Console.WriteLine("2 - Задача 4: Сумма цифр числа (рекурсия)");
            Console.WriteLine("3 - Задача 6: Разделение числа");
            Console.WriteLine("4 - Задача 8: Длины строк  ");
            Console.WriteLine("0 - Назад в главное меню");
            Console.Write("Введите номер задачи: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task5_2(); break;
                case "2": Task5_4(); break;
                case "3": Task5_6(); break;
                case "4": Task5_8(); break;
                case "0": exitBlock = true; break;
                default:
                    Console.WriteLine("Неверный выбор. Нажмите любую клавишу.");
                    Console.ReadKey();
                    break;
            }

            if (!exitBlock)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    static void Task1_2()
    {

        /*Индекс массы тела (ИМТ): пользователь вводит рост (в сантиметрах) и
        вес (в килограммах), программа рассчитывает ИМТ по формуле ИМТ =
        вес / (рост в метрах)², округляя результат до одного знака после запятой.*/

        Console.Write("Введите рост: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите вес: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double imt = (double)weight / Math.Pow((double)height / 100, 2);
        Console.WriteLine($"IMT = {imt:F1}");
    }



    static void Task1_4()
    {

        /*Перевод времени: пользователь вводит количество секунд, программа
        переводит это значение в часы, минуты и секунды.*/

        Console.WriteLine("Введите количество секунд: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int secs = seconds % 60;
        Console.WriteLine($"{hours}:{minutes}:{secs}");
    }


    static void Task1_6()
    {
        /*Цена со скидкой: пользователь вводит первоначальную цену товара и
        размер скидки в процентах, программа рассчитывает итоговую цену с
        учётом скидки.*/

        Console.Write("Введите первоначальную цену товара (в рублях): ");
        double originalPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите размер скидки (%): ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discountAmount = originalPrice * (discountPercent / 100);
        double finalPrice = originalPrice - discountAmount;
        Console.WriteLine($"Итоговая цена: {finalPrice:F2} руб.");
    }

    static void Task2_2()
    {
        /*Тип треугольника: пользователь вводит длины трёх сторон, программа
        определяет тип треугольника — равносторонний, равнобедренный или
        разносторонний.*/
        Console.Write("Введите длину стороны A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину стороны B: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите длину стороны C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник равносторонний.");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Треугольник равнобедренный.");
        }
        else
        {
            Console.WriteLine("Треугольник разносторонний.");
        }
    }



    static void Task2_4()
    {
        /*Оценка по числу: пользователь вводит оценку (от 1 до 5), программа
    выводит текстовое описание оценки с использованием switch — Плохо,
    Неудовлетворительно, Удовлетворительно, Хорошо, Отлично.*/

        Console.Write("Введите оценку (целое число от 1 до 5): ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Плохо");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Ошибка: оценка должна быть от 1 до 5.");
                    break;
            }
        }
    }

    static void Task2_6()
    {
        /*Конвертация валют: пользователь вводит сумму в рублях и выбирает
    валюту (доллар, фунт, евро), программа переводит сумму по
    соответствующему курсу, используя switch.*/
        {
            // Курсы валют (условные, на момент написания)
            const double USD_RATE = 0.011; // 1 RUB = 0.011 USD
            const double EUR_RATE = 0.010; // 1 RUB = 0.010 EUR
            const double GBP_RATE = 0.0085; // 1 RUB = 0.0085 GBP
            Console.WriteLine("=== Конвертер валют ===");
            Console.Write("Введите сумму в рублях: ");
            // Проверка корректности ввода суммы
            if (!double.TryParse(Console.ReadLine(), out double rubles) || rubles < 0)
            {
                Console.WriteLine("Ошибка: введите корректную неотрицательную сумму.");
                return;
            }
            Console.WriteLine("Выберите валюту для конвертации:");
            Console.WriteLine("1 — Доллар США (USD)");
            Console.WriteLine("2 — Евро (EUR)");
            Console.WriteLine("3 — Британский фунт (GBP)");
            Console.Write("Ваш выбор (1/2/3): ");
            string choice = Console.ReadLine();
            double result = 0;
            string currencySymbol = "";
            switch (choice)
            {
                case "1":
                    result = rubles * USD_RATE;
                    currencySymbol = "USD";
                    break;
                case "2":
                    result = rubles * EUR_RATE;
                    currencySymbol = "EUR";
                    break;
                case "3":
                    result = rubles * GBP_RATE;
                    currencySymbol = "GBP";
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор валюты.");
                    return;
            }
            Console.WriteLine($"{rubles:F2} рублей = {result:F2} {currencySymbol}");
        }

    }

    static void Task3_2()
    {
        /*Переворот числа: пользователь вводит целое число, программа
    переворачивает его (например, 123 → 321).*/
        {
            Console.Write("Введите целое число: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                bool isNegative = number < 0;
                int n = Math.Abs(number);
                int reversedNumber = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    n /= 10;
                }
                if (isNegative)
                    reversedNumber = -reversedNumber;
                Console.WriteLine($"Перевернутое число: {reversedNumber}");
            }
            else
            {
                Console.WriteLine("Введено не целое число.");
            }
        }
    }

    static void Task3_4()
    {
        /*. Максимальное нечётное число: пользователь вводит границы диапазона
    [a, b], программа находит максимальное нечётное число в этом диапазоне.*/
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine()); 
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            // Начинаем с верхней границы и ищем первое нечётное число
            int maxOdd = b % 2 != 0 ? b : b - 1;
            if (maxOdd < a)
            {
                Console.WriteLine("В заданном диапазоне нет нечётных чисел.");
            }
            else
            {
                Console.WriteLine($"Максимальное нечётное число в диапазоне: {maxOdd}");
            }
        }
    }

    static void Task3_6()
    {
        /* Арифметическая прогрессия: пользователь вводит количество членов n,
первый член и шаг прогрессии, программа выводит n членов прогрессии
и их сумму*/
        {
            Console.Write("Введите количество членов прогрессии (n): ");
            bool isNValid = int.TryParse(Console.ReadLine(), out int n);
            Console.Write("Введите первый член прогрессии: ");
            bool isFirstValid = double.TryParse(Console.ReadLine(), out double firstTerm);
            Console.Write("Введите шаг прогрессии: ");
            bool isStepValid = double.TryParse(Console.ReadLine(), out double step);
            if (!isNValid || !isFirstValid || !isStepValid || n <= 0)
            {
                Console.WriteLine("Введены некорректные данные.");
                return;
            }
            double sum = 0;
            Console.WriteLine("Члены арифметической прогрессии:");
            for (int i = 0; i < n; i++)
            {
                double term = firstTerm + i * step;
                Console.Write(term + (i < n - 1 ? ", " : ""));
                sum += term;
            }
            Console.WriteLine($"\nСумма членов прогрессии: {sum}");
        }
    }

    static void Task4_2()
    {
        /*Второй по величине элемент: пользователь задаёт размер одномерного
        массива, массив заполняется случайными числами от 1 до 100. Программа
        находит второй по величине элемент и его индекс.*/

        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Создаем массив
        int[] numbers = new int[size];

        // Заполняем случайными числами
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1, 101); // числа от 1 до 100
        }

        // Выводим массив
        Console.WriteLine("\nПолучившийся массив:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"numbers[{i}] = {numbers[i]}");
        }

        // Ищем максимальный элемент
        int max = numbers[0];
        for (int i = 1; i < size; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Ищем второй по величине элемент
        int secondMax = -1; // начальное значение
        int secondMaxIndex = -1;

        for (int i = 0; i < size; i++)
        {
            // Если число меньше максимального, но больше текущего второго максимума
            if (numbers[i] < max && numbers[i] > secondMax)
            {
                secondMax = numbers[i];
                secondMaxIndex = i;
            }
        }

        // Вывод результата
        if (secondMaxIndex != -1)
        {
            Console.WriteLine($"\nВторой по величине элемент: {secondMax}");
            Console.WriteLine($"Его индекс: {secondMaxIndex}");
        }
        else
        {
            Console.WriteLine("\nВторого по величине элемента нет (все числа одинаковые)");
        }
    }

    static void Task4_4()
    {
        /*Чётные элементы в столбцах: пользователь задаёт размеры двумерного
    массива, массив заполняется случайными числами от 1 до 100. Программа
    считает количество чётных элементов в каждом столбце и определяет
    столбец с максимальным количеством чётных чисел.
    */
        {
            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, cols];
            Random rand = new Random();
            // Заполнение массива случайными числами от 1 до 100
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(1, 101);
                }
            }
            // Вывод массива
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Подсчёт количества чётных элементов в каждом столбце
            int maxEvenCount = -1;
            int maxEvenColumnIndex = -1;
            for (int j = 0; j < cols; j++)
            {
                int evenCount = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }
                }
                Console.WriteLine($"Столбец {j + 1}: количество чётных чисел = {evenCount}");
                if (evenCount > maxEvenCount)
                {
                    maxEvenCount = evenCount;
                    maxEvenColumnIndex = j;
                }
            }
            Console.WriteLine($"Столбец с максимальным количеством чётных чисел: {maxEvenColumnIndex + 1} ({maxEvenCount} чётных чисел)");
        }
    }

    static void Task4_6()
    {
        /*Диагонали матрицы: в двумерной матрице программа находит
    максимальные элементы на главной и побочной диагоналях и вычисляет
    их сумму.*/
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Random rand = new Random();
            // Заполнение матрицы случайными числами от 1 до 100
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 101);
                }
            }
            // Вывод матрицы
            Console.WriteLine("Матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Поиск максимального элемента главной диагонали
            int maxMainDiagonal = matrix[0, 0];
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > maxMainDiagonal)
                    maxMainDiagonal = matrix[i, i];
            }
            // Поиск максимального элемента побочной диагонали
            int maxSecondaryDiagonal = matrix[0, n - 1];
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, n - 1 - i] > maxSecondaryDiagonal)
                    maxSecondaryDiagonal = matrix[i, n - 1 - i];
            }
            int sum = maxMainDiagonal + maxSecondaryDiagonal;
            Console.WriteLine($"Максимальный элемент главной диагонали: {maxMainDiagonal}");
            Console.WriteLine($"Максимальный элемент побочной диагонали: {maxSecondaryDiagonal}");
            Console.WriteLine($"Сумма максимальных элементов диагоналей: {sum}");
        }
    }
    static void Task5_2()
    {
        /*Генерация массива: реализовать функцию GenerateArray(int count, int min,
        int max), возвращающую массив случайных чисел.*/
        int count = 10; // размер массива
        int min = 1;    // минимальное значение
        int max = 100;  // максимальное значение
        int[] array = GenerateArray(count, min, max);
        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] GenerateArray(int count, int min, int max)
    {
        Random rand = new Random();
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = rand.Next(min, max + 1); // max+1, чтобы включить max
        }
        return result;
    }

    static void Task5_4()
    {
        /* Сумма цифр числа (рекурсия): реализовать рекурсивную функцию
        DigitSum(int number), возвращающую сумму цифр числа.*/
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int sum = DigitSum(Math.Abs(number));
            Console.WriteLine($"Сумма цифр числа: {sum}");
        }
        else
        {
            Console.WriteLine("Введено не целое число.");
        }
    }

    static int DigitSum(int number)
    {
        if (number == 0)
            return 0;
        return number % 10 + DigitSum(number / 10);
    }

    static void Task5_6()
    {
        /*Разделение числа: реализовать функцию Split(double number, out int whole,
    out double fraction), разделяющую число на целую и дробную части.*/
        double number = 123.456;
        Split(number, out int whole, out double fraction);
        Console.WriteLine($"Число: {number}");
        Console.WriteLine($"Целая часть: {whole}");
        Console.WriteLine($"Дробная часть: {fraction}");
    }

    static void Split(double number, out int whole, out double fraction)
    {
        whole = (int)number;
        fraction = number - whole;
    }

    static void Task5_8()
    {
        /*Длины строк: реализовать функцию GetLengths(params string[] strings),
         возвращающую массив длин каждой строки. Строки при вызове функции
         передаются списком параметров например GetLengths("My", "Name", "Is",
         "Jabbar", "I", "Live", "In", "Qatar")*/
        int[] lengths = GetLengths("My", "Name", "Is", "Jabbar", "I", "Live", "In", "Qatar");

        Console.WriteLine("Длины строк:");
        foreach (int length in lengths)
        {
            Console.Write(length + " ");
        }
        Console.WriteLine();
    }
    static int[] GetLengths(params string[] strings)
    {
        int[] lengths = new int[strings.Length];
        for (int i = 0; i < strings.Length; i++)
        {
            lengths[i] = strings[i].Length;
        }
        return lengths;
    }


}
