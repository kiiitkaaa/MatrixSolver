using System;
using System.Collections.Generic;

namespace MatrixSolver
{
    /// <summary>
    /// Класс для работы с матрицей
    /// </summary>
    public class Matrix : IMatrix
    {
        public List<string> SolveGauss(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1) - 1;

            double[,] a = (double[,])matrix.Clone();
            bool[] isFree = new bool[m]; // какие переменные свободные

            for (int i = 0, j = 0; i < n && j < m; j++)
            {
                // Поиск главного элемента в столбце j
                int pivotRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(a[k, j]) > Math.Abs(a[pivotRow, j]))
                        pivotRow = k;
                }

                if (Math.Abs(a[pivotRow, j]) < 1e-12)
                {
                    isFree[j] = true;
                    continue;
                }

                // Меняем строки
                if (pivotRow != i)
                {
                    for (int k = 0; k <= m; k++)
                    {
                        (a[pivotRow, k], a[i, k]) = (a[i, k], a[pivotRow, k]);
                    }
                }

                // Нормализация ведущего элемента
                double pivot = a[i, j];
                for (int k = 0; k <= m; k++)
                    a[i, k] /= pivot;

                // Обнуление всех строк кроме текущей
                for (int k = 0; k < n; k++)
                {
                    if (k != i && Math.Abs(a[k, j]) > 1e-12)
                    {
                        double factor = a[k, j];
                        for (int l = 0; l <= m; l++)
                            a[k, l] -= factor * a[i, l];
                    }
                }

                i++;
            }

            // Теперь строим выражения для переменных
            List<string> result = new List<string>();
            for (int i = 0; i < m; i++)
            {
                if (isFree[i])
                {
                    result.Add($"x{i + 1} = свободная переменная");
                }
                else
                {
                    // Найдем строку, где ведущая переменная стоит
                    int row = -1;
                    for (int r = 0; r < n; r++)
                    {
                        if (Math.Abs(a[r, i] - 1) < 1e-12)
                        {
                            row = r;
                            break;
                        }
                    }

                    string expr = $"x{i + 1} = {a[row, m]:F4}";
                    for (int j = i + 1; j < m; j++)
                    {
                        if (Math.Abs(a[row, j]) > 1e-12)
                        {
                            double coeff = -a[row, j];
                            if (coeff >= 0)
                                expr += $" + {coeff:F4}*x{j + 1}";
                            else
                                expr += $" - {Math.Abs(coeff):F4}*x{j + 1}";
                        }
                    }
                    result.Add(expr);
                }
            }

            return result;
        }

        public double Determinant(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Проверка, что матрица квадратная
            if (n != matrix.GetLength(1))
                throw new ArgumentException("Матрица должна быть квадратной.");

            // Копируем матрицу, чтобы не изменять исходную
            double[,] temp = (double[,])matrix.Clone();
            double det = 1;
            int swapCount = 0;

            for (int i = 0; i < n; i++)
            {
                // Поиск ведущего элемента
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(temp[k, i]) > Math.Abs(temp[maxRow, i]))
                        maxRow = k;
                }

                // Если ведущий элемент — 0, то определитель равен 0
                if (Math.Abs(temp[maxRow, i]) < 1e-12)
                    return 0;

                // Перестановка строк при необходимости
                if (i != maxRow)
                {
                    for (int j = 0; j < n; j++)
                    {
                        (temp[maxRow, j], temp[i, j]) = (temp[i, j], temp[maxRow, j]);
                    }
                    swapCount++;
                }

                // Приведение ниже диагонали к нулям
                for (int k = i + 1; k < n; k++)
                {
                    double factor = temp[k, i] / temp[i, i];
                    for (int j = i; j < n; j++)
                    {
                        temp[k, j] -= factor * temp[i, j];
                    }
                }
            }

            // Определитель — произведение диагональных элементов
            for (int i = 0; i < n; i++)
                det *= temp[i, i];

            // Если было нечётное число перестановок строк — поменять знак
            if (swapCount % 2 != 0)
                det = -det;

            return det;
        }

        public double[,] InvertMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Проверка на квадратность
            if (n != matrix.GetLength(1))
                throw new ArgumentException("Матрица должна быть квадратной.");

            // Создаем расширенную матрицу (слева — исходная, справа — единичная)
            double[,] augmented = new double[n, 2 * n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmented[i, j] = matrix[i, j];
                }
                augmented[i, n + i] = 1.0;
            }

            // Прямой ход
            for (int i = 0; i < n; i++)
            {
                // Поиск ведущего элемента
                double pivot = augmented[i, i];
                if (Math.Abs(pivot) < 1e-12)
                {
                    // Попробуем поменять строки
                    bool found = false;
                    for (int k = i + 1; k < n; k++)
                    {
                        if (Math.Abs(augmented[k, i]) > 1e-12)
                        {
                            // Перестановка строк
                            for (int j = 0; j < 2 * n; j++)
                            {
                                (augmented[k, j], augmented[i, j]) = (augmented[i, j], augmented[k, j]);
                            }
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        return null;

                    pivot = augmented[i, i];
                }

                // Нормализация строки
                for (int j = 0; j < 2 * n; j++)
                    augmented[i, j] /= pivot;

                // Обнуление остальных строк
                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = augmented[k, i];
                    for (int j = 0; j < 2 * n; j++)
                    {
                        augmented[k, j] -= factor * augmented[i, j];
                    }
                }
            }

            // Извлекаем правую половину как обратную матрицу
            double[,] inverse = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse[i, j] = augmented[i, j + n];
                }
            }

            return inverse;
        }

        public double[,] TransposeMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Проверка на квадратность
            if (n != matrix.GetLength(1))
                throw new ArgumentException("Матрица должна быть квадратной.");

            double[,] transposed = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }
    }
}
