using System;
using System.Windows.Forms;

namespace coursework.Forms
{
    /// <summary>
    /// Класс для отображение обработанной матрицы
    /// </summary>
    public partial class DisplayMatrix : Form
    {
        /// <summary>
        /// Обработанная матрица
        /// </summary>
        public double[,] Matrix { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="operation">Тип операции над матрицей</param>
        /// <param name="matrix">Обработанная матрица</param>
        public DisplayMatrix(string operation, double[,] matrix)
        {
            InitializeComponent();

            Text = operation;
            Matrix = matrix;
        }

        /// <summary>
        /// Отрисовка матрицы при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayMatrix_Load(object sender, EventArgs e)
        {
            CalculatedMatrix_dataGridView.Columns.Clear();
            CalculatedMatrix_dataGridView.Rows.Clear();

            int rows = Matrix.GetLength(0);
            int cols = Matrix.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                CalculatedMatrix_dataGridView.Columns.Add($"col{j}", $"X{j + 1}");
            }

            for (int i = 0; i < rows; i++)
            {
                object[] row = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = Math.Round(Matrix[i, j], 4); // округление
                }
                CalculatedMatrix_dataGridView.Rows.Add(row);
            }

            CalculatedMatrix_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
