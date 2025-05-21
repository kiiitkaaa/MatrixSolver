using System.Windows.Forms;

namespace coursework.Classes
{
    /// <summary>
    /// Класс для работы с DataGridView
    /// </summary>
    public static class DataGridHelper
    {
        /// <summary>
        /// Вычисление системы методом Жордана-Гаусса
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        /// <param name="Result_ListBox">ListBox с полем ответа</param>
        /// <param name="size">Количество неизвестных</param>
        public static void CalculateMatrix(DataGridView Matrix_DataGridView, ListBox Result_ListBox, int size, MatrixSolver.IMatrix matrixSolver)
        {
            double[,] matrix = GetClearMatrix(Matrix_DataGridView, Result_ListBox, size);
            if (matrix == null)
                return;

            var solutions = matrixSolver.SolveGauss(matrix);

            Result_ListBox.Items.Clear();

            foreach (var solution in solutions)
            {
                Result_ListBox.Items.Add(solution);
            }
        }

        /// <summary>
        /// Генерация области с таблицнй
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        /// <param name="Result_ListBox">ListBox с полем ответа</param>
        /// <param name="size">Количество неизвестных</param>
        public static void GenerateTable(DataGridView Matrix_DataGridView, ListBox Result_ListBox, int size)
        {
            Matrix_DataGridView.Columns.Clear();
            Matrix_DataGridView.Rows.Clear();

            Matrix_DataGridView.Columns.Add("colNumber", "№");

            for (int i = 1; i <= size; i++)
            {
                Matrix_DataGridView.Columns.Add($"colX{i}", $"X{i}");
            }

            Matrix_DataGridView.Columns.Add("colY", "Y");

            for (int i = 1; i <= size; i++)
            {
                var rowIndex = Matrix_DataGridView.Rows.Add();
                Matrix_DataGridView.Rows[rowIndex].Cells[0].Value = i;
            }

            Matrix_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Result_ListBox.Items.Clear();
        }

        /// <summary>
        /// Получение расширенной матрицы
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        /// <param name="Result_ListBox">ListBox с полем ответа</param>
        /// <param name="size">Количество неизвестных</param>
        /// <returns>Двумерный массив с расширенной матрицей</returns>
        public static double[,] GetClearMatrix(DataGridView Matrix_DataGridView, ListBox Result_ListBox, int size)
        {
            double[,] matrix = new double[size, size + 1];
            bool isMatrixEmpty = true;

            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j <= size + 1; j++)
                {
                    var cellValue = Matrix_DataGridView.Rows[i].Cells[j].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(cellValue))
                    {
                        isMatrixEmpty = false;
                    }

                    if (double.TryParse(cellValue, out double number))
                    {
                        matrix[i, j - 1] = number;
                    }
                    else
                    {
                        if (cellValue != null)
                        {
                            string columnName = Matrix_DataGridView.Columns[j].HeaderText;
                            int rowNumber = i + 1;

                            MessageBox.Show(text:
                                $"Ошибка ввода в ячейке:\nСтрока: {rowNumber}, Столбец: {columnName}\nЗначение заменено на 0.",
                                caption: "Ошибка ввода",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            matrix[i, j - 1] = 0;
                            Matrix_DataGridView.Rows[i].Cells[j].Value = 0;
                        }
                        else
                        {
                            matrix[i, j - 1] = 0;
                            Matrix_DataGridView.Rows[i].Cells[j].Value = 0;
                        }
                    }
                }
            }

            if (isMatrixEmpty)
            {
                GenerateTable(Matrix_DataGridView, Result_ListBox, size);

                MessageBox.Show(text: "Матрица пуста. Пожалуйста, введите значения.",
                    caption: "Пустая матрица", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return matrix;
        }

        /// <summary>
        /// Генерация определённой системы
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        public static void GenerateDefinedSystem(DataGridView Matrix_DataGridView)
        {
            double[,] matrix = new double[,]
            {
                { 2, -1, 1, 3 },
                { 1,  1, 1, 6 },
                { 1, -1, 2, 4 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Matrix_DataGridView.Rows[i].Cells[j + 1].Value = matrix[i, j];
                }
            }
        }

        /// <summary>
        /// Генерация неопределённой системы
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        public static void GenerateIndefiniteSystem(DataGridView Matrix_DataGridView)
        {
            double[,] matrix = new double[,]
            {
                { 1, 2, -1, 4 },
                { 2, 4, -2, 8 },
                { 0, 0, 0, 0 }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Matrix_DataGridView.Rows[i].Cells[j + 1].Value = matrix[i, j];
                }
            }
        }

        /// <summary>
        /// Получение квадратной матрицы 
        /// </summary>
        /// <param name="Matrix_DataGridView">DataGridView с матрицей</param>
        /// <param name="Result_ListBox">ListBox с полем ответа</param>
        /// <param name="size">Количество неизвестных</param>
        /// <returns>Двемерный массив с квадратной матрицей</returns>
        public static double[,] GetSquareMatrix(DataGridView Matrix_DataGridView, ListBox Result_ListBox, int size)
        {
            double[,] matrix = new double[size, size];
            bool isMatrixEmpty = true;

            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    var cellValue = Matrix_DataGridView.Rows[i].Cells[j].Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(cellValue))
                    {
                        isMatrixEmpty = false;
                    }

                    if (double.TryParse(cellValue, out double number))
                    {
                        matrix[i, j - 1] = number;
                    }
                    else
                    {
                        string columnName = Matrix_DataGridView.Columns[j].HeaderText;
                        int rowNumber = i + 1;

                        MessageBox.Show(
                            text: $"Ошибка ввода в ячейке:\nСтрока: {rowNumber}, Столбец: {columnName}\nЗначение заменено на 0.",
                            caption: "Ошибка ввода",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        matrix[i, j - 1] = 0;
                        Matrix_DataGridView.Rows[i].Cells[j].Value = 0;
                    }
                }
            }

            if (isMatrixEmpty)
            {
                GenerateTable(Matrix_DataGridView, Result_ListBox, size);

                MessageBox.Show(text: "Матрица пуста. Пожалуйста, введите значения.",
                    caption: "Пустая матрица", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            return matrix;
        }

        /// <summary>
        /// Получение данных из таблицы
        /// </summary>
        /// <param name="Matrix_DataGridView"></param>
        /// <returns>Строковый двумерный массив</returns>
        public static string[,] GetDataFromDataGridView(DataGridView Matrix_DataGridView)
        {
            int rows = Matrix_DataGridView.RowCount;
            int columns = Matrix_DataGridView.ColumnCount;

            string[,] result = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Matrix_DataGridView.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                }
            }

            return result;
        }
    }
}
