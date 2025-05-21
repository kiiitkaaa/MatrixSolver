using System.Collections.Generic;

namespace MatrixSolver
{
    public interface IMatrix
    {
        /// <summary>
        /// Решение системы уравнений методом Гаусса-Жордана
        /// </summary>
        /// <param name="matrix">Расширенная матрица системы</param>
        /// <returns>Список строк с результатами (корни или выражения)</returns>
        List<string> SolveGauss(double[,] matrix);

        /// <summary>
        /// Вычисление определителя квадратной матрицы
        /// </summary>
        /// <param name="matrix">Квадратная матрица</param>
        /// <returns>Определитель</returns>
        double Determinant(double[,] matrix);

        /// <summary>
        /// Вычисление обратной матрицы
        /// </summary>
        /// <param name="matrix">Квадратная матрица</param>
        /// <returns>Обратная матрица или null, если не существует</returns>
        double[,] InvertMatrix(double[,] matrix);

        /// <summary>
        /// Вычисление транспонированной матрицы
        /// </summary>
        /// <param name="matrix">Квадратная матрица</param>
        /// <returns>Транспонированная матрица</returns>
        double[,] TransposeMatrix(double[,] matrix);
    }
}
