class Program
{
    static void Main(string[] args)
    {
        // Создаем две матрицы 2x3
        Matrix m1 = new Matrix(2, 3);
        Matrix m2 = new Matrix(2, 3);

        // Заполняем m1
        m1[0, 0] = 1; m1[0, 1] = 2; m1[0, 2] = 3;
        m1[1, 0] = 4; m1[1, 1] = 5; m1[1, 2] = 6;

        // Заполняем m2
        m2[0, 0] = 6; m2[0, 1] = 5; m2[0, 2] = 4;
        m2[1, 0] = 3; m2[1, 1] = 2; m2[1, 2] = 1;

        Console.WriteLine("Матрица m1:");
        Console.WriteLine(m1);
        Console.WriteLine("Матрица m2:");
        Console.WriteLine(m2);

        Console.WriteLine("m1 + m2:");
        Console.WriteLine(m1 + m2);

        Console.WriteLine("m1 - m2:");
        Console.WriteLine(m1 - m2);

        Console.WriteLine("m1 * m2 (поэлементное):");
        Console.WriteLine(m1 * m2);

        Console.WriteLine("m1 / 2 (деление на число):");
        Console.WriteLine(m1 / 2);

        // Умножение матриц (2x3 * 3x2)
        Matrix m3 = new Matrix(3, 2);
        m3[0, 0] = 1; m3[0, 1] = 2;
        m3[1, 0] = 3; m3[1, 1] = 4;
        m3[2, 0] = 5; m3[2, 1] = 6;

        Console.WriteLine("Матрица m3:");
        Console.WriteLine(m3);

        Console.WriteLine("m1 * m3 (матричное умножение):");
        Console.WriteLine(m1 * m3);

        Console.WriteLine($"m1.Equals(m2): {m1.Equals(m2)}"); // true, у обеих 6 элементов
        Console.WriteLine($"m1.Equals(m3): {m1.Equals(m3)}"); // false, 6 != 6 (2*3 vs 3*2 равны, значит true, исправим!)

        // Исправление Equals: учитываем именно количество элементов, (2*3=6 и 3*2=6) являются равными
    }
}
