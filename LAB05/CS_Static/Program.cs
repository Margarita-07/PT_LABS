using CS_Static;

class Program
{
    static void Main()
    {
        try
        {
            // Создание двух матриц
            Matrix m1 = new Matrix(2, 3);
            m1[0, 0] = 1; m1[0, 1] = 2; m1[0, 2] = 3;
            m1[1, 0] = 4; m1[1, 1] = 5; m1[1, 2] = 6;

            Matrix m2 = new Matrix(2, 3);
            m2[0, 0] = 7; m2[0, 1] = 8; m2[0, 2] = 9;
            m2[1, 0] = 10; m2[1, 1] = 11; m2[1, 2] = 12;

            Console.WriteLine("Матрица m1:");
            Console.WriteLine(m1);

            Console.WriteLine("Матрица m2:");
            Console.WriteLine(m2);

            // Поэлементное сложение
            Matrix sum = m1 + m2;
            Console.WriteLine("m1 + m2:");
            Console.WriteLine(sum);

            // Поэлементное вычитание
            Matrix diff = m1 - m2;
            Console.WriteLine("m1 - m2:");
            Console.WriteLine(diff);

            // Умножение на число
            Matrix scaled = m1 * 2.0;
            Console.WriteLine("m1 * 2:");
            Console.WriteLine(scaled);

            // Деление на число
            Matrix divided = m1 / 2.0;
            Console.WriteLine("m1 / 2:");
            Console.WriteLine(divided);

            // Матричное умножение (нужны совместимые размеры)
            Matrix m3 = new Matrix(3, 2);
            m3[0, 0] = 1; m3[0, 1] = 2;
            m3[1, 0] = 3; m3[1, 1] = 4;
            m3[2, 0] = 5; m3[2, 1] = 6;

            Matrix product = m1 * m3; // 2x3 * 3x2 => 2x2
            Console.WriteLine("m1 * m3 (матричное умножение):");
            Console.WriteLine(product);

            // Проверка Equals (по количеству элементов)
            Matrix m4 = new Matrix(3, 2); // 6 элементов
            Console.WriteLine($"m1.Equals(m4): {m1.Equals(m4)}"); // true, обе 2x3 и 3x2 → 6 элементов

            Matrix m5 = new Matrix(2, 2); // 4 элемента
            Console.WriteLine($"m1.Equals(m5): {m1.Equals(m5)}"); // false

            // Проверка изменения размера через свойства
            m1.Cols = 2;
            Console.WriteLine("После изменения m1.Cols = 2:");
            Console.WriteLine(m1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

