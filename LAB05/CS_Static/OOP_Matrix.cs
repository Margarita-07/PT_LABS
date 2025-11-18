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

        public int Rows
        {
            get => rows;
            set
            {
                if (value <= 0) throw new ArgumentException("Количество строк должно быть положительным");
                rows = value;
                ResizeData();
            }
        }

        public int Cols
        {
            get => cols;
            set
            {
                if (value <= 0) throw new ArgumentException("Количество столбцов должно быть положительным");
                cols = value;
                ResizeData();
            }
        }

        public double this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= rows || j < 0 || j >= cols)
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                return data[i, j];
            }
            set
            {
                if (i < 0 || i >= rows || j < 0 || j >= cols)
                    throw new IndexOutOfRangeException("Индекс вне диапазона");
                data[i, j] = value;
            }
        }

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
                throw new ArgumentException("Размерность матрицы должна быть положительной");
            this.rows = rows;
            this.cols = cols;
            data = new double[rows, cols];
        }

        private void ResizeData()
        {
            var newData = new double[rows, cols];
            int minRows = Math.Min(rows, data?.GetLength(0) ?? 0);
            int minCols = Math.Min(cols, data?.GetLength(1) ?? 0);

            if (data != null)
            {
                for (int i = 0; i < minRows; i++)
                    for (int j = 0; j < minCols; j++)
                        newData[i, j] = data[i, j];
            }
            data = newData;
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < cols; j++)
                    sb.Append($"{data[i, j],8:F2} ");
                sb.AppendLine("]");
            }
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix m)
                return this.rows * this.cols == m.rows * m.cols;
            return false;
        }

        public override int GetHashCode()
        {
            return rows * 397 ^ cols;
        }

        // Поэлементное сложение
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.rows != b.rows || a.cols != b.cols)
                throw new InvalidOperationException("Размерности матриц должны совпадать для поэлементных операций");

            var result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < a.cols; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return result;
        }

        // Поэлементное вычитание
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.rows != b.rows || a.cols != b.cols)
                throw new InvalidOperationException("Размерности матриц должны совпадать для поэлементных операций");

            var result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < a.cols; j++)
                    result[i, j] = a[i, j] - b[i, j];

            return result;
        }

        // Поэлементное умножение
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.rows != b.rows || a.cols != b.cols)
                throw new InvalidOperationException("Размерности матриц должны совпадать для поэлементных операций");

            var result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < a.cols; j++)
                    result[i, j] = a[i, j] * b[i, j];

            return result;
        }

        // Умножение матрицы на число
        public static Matrix operator /(Matrix a, double scalar)
        {
            if (scalar == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");

            var result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < a.cols; j++)
                    result[i, j] = a[i, j] / scalar;

            return result;
        }

        // Умножение двух матриц (стандартное)
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.cols != b.rows)
                throw new InvalidOperationException("Количество столбцов первой матрицы должно равняться количеству строк второй");

            var result = new Matrix(a.rows, b.cols);
            for (int i = 0; i < result.rows; i++)
            {
                for (int j = 0; j < result.cols; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.cols; k++)
                        sum += a[i, k] * b[k, j];
                    result[i, j] = sum;
                }
            }
            return result;
        }
    }




}

