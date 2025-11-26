using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Static
{
    public class Matrix
    {
        private int rows;
        private int cols;
        private double[,] data;

        // Свойства с проверкой
        public int Rows
        {
            get => rows;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество строк должно быть положительным.");
                if (value != rows)
                {
                    // При изменении размера — создаём новую матрицу
                    double[,] newData = new double[value, cols];
                    int copyRows = Math.Min(rows, value);
                    for (int i = 0; i < copyRows; i++)
                        for (int j = 0; j < cols; j++)
                            newData[i, j] = data[i, j];
                    data = newData;
                    rows = value;
                }
            }
        }

        public int Cols
        {
            get => cols;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество столбцов должно быть положительным.");
                if (value != cols)
                {
                    double[,] newData = new double[rows, value];
                    int copyCols = Math.Min(cols, value);
                    for (int i = 0; i < rows; i++)
                        for (int j = 0; j < copyCols; j++)
                            newData[i, j] = data[i, j];
                    data = newData;
                    cols = value;
                }
            }
        }

        public double this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                    throw new IndexOutOfRangeException("Индекс за пределами матрицы.");
                return data[row, col];
            }
            set
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols)
                    throw new IndexOutOfRangeException("Индекс за пределами матрицы.");
                data[row, col] = value;
            }
        }

        // Конструктор с параметрами
        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размеры матрицы должны быть положительными.");
            this.rows = rows;
            this.cols = cols;
            data = new double[rows, cols];
        }

        // Конструктор копирования (опционально, но полезен)
        public Matrix(Matrix other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            rows = other.rows;
            cols = other.cols;
            data = new double[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    data[i, j] = other.data[i, j];
        }

        // Поэлементное сложение
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
                throw new ArgumentException("Матрицы должны иметь одинаковые размеры для поэлементного сложения.");
            Matrix result = new Matrix(m1.rows, m1.cols);
            for (int i = 0; i < m1.rows; i++)
                for (int j = 0; j < m1.cols; j++)
                    result[i, j] = m1[i, j] + m2[i, j];
            return result;
        }

        // Поэлементное вычитание
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
                throw new ArgumentException("Матрицы должны иметь одинаковые размеры для поэлементного вычитания.");
            Matrix result = new Matrix(m1.rows, m1.cols);
            for (int i = 0; i < m1.rows; i++)
                for (int j = 0; j < m1.cols; j++)
                    result[i, j] = m1[i, j] - m2[i, j];
            return result;
        }

        //Поэлементное умножение матриц
        public static Matrix ElementwiseMultiply(Matrix m1, Matrix m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
                throw new ArgumentException("Матрицы должны иметь одинаковые размеры для поэлементного умножения.");
            Matrix result = new Matrix(m1.rows, m1.cols);
            for (int i = 0; i < m1.rows; i++)
                for (int j = 0; j < m1.cols; j++)
                    result[i, j] = m1[i, j] * m2[i, j];
            return result;
        }


        // Перегрузка: матричное умножение
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.cols != m2.rows)
                throw new ArgumentException("Количество столбцов первой матрицы должно совпадать с количеством строк второй для матричного умножения.");
            Matrix result = new Matrix(m1.rows, m2.cols);
            for (int i = 0; i < m1.rows; i++)
                for (int j = 0; j < m2.cols; j++)
                    for (int k = 0; k < m1.cols; k++)
                        result[i, j] += m1[i, k] * m2[k, j];
            return result;
        }

        // Поэлементное умножение на число (левый и правый операнд)
        public static Matrix operator *(Matrix m, double scalar)
        {
            Matrix result = new Matrix(m.rows, m.cols);
            for (int i = 0; i < m.rows; i++)
                for (int j = 0; j < m.cols; j++)
                    result[i, j] = m[i, j] * scalar;
            return result;
        }

        public static Matrix operator *(double scalar, Matrix m)
        {
            return m * scalar;
        }

        // Деление матрицы на число
        public static Matrix operator /(Matrix m, double scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            Matrix result = new Matrix(m.rows, m.cols);
            for (int i = 0; i < m.rows; i++)
                for (int j = 0; j < m.cols; j++)
                    result[i, j] = m[i, j] / scalar;
            return result;
        }

        // Переопределение ToString
        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(data[i, j].ToString("F2").PadLeft(8));
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        // Equals: сравнение по количеству элементов (rows * cols)
        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                return this.rows * this.cols == other.rows * other.cols;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return rows * cols;
        }
    }
}




