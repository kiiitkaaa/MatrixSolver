using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using coursework.Forms;
using MatrixSolver;
using Reports;
using coursework.Classes;
using System.Threading;

namespace coursework
{
    /// <summary>
    /// Класс главного окна
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Размер основной матрицы
        /// </summary>
        public int SizeMatrix { get; private set; }

        private readonly MatrixSolver.IMatrix matrix = new Matrix();
        private IReport report;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            SizeMatrix = 2;
            DataGridHelper.GenerateTable(Matrix_DataGridView: Matrix_DataGridView, size: SizeMatrix, Result_ListBox: Result_ListBox);
        }

        /// <summary>
        /// Кнопка для выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Изменение количества неизвестных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberMatrix_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SizeMatrix = (int)NumberMatrix_NumericUpDown.Value;
            DataGridHelper.GenerateTable(Matrix_DataGridView: Matrix_DataGridView, size: SizeMatrix, Result_ListBox: Result_ListBox);
        }

        /// <summary>
        /// Расчёт систеы уравнений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DataGridHelper.CalculateMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix, matrixSolver: matrix);
        }

        /// <summary>
        /// Очистка таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SizeMatrix = (int)NumberMatrix_NumericUpDown.Value;
            DataGridHelper.GenerateTable(Matrix_DataGridView: Matrix_DataGridView, size: SizeMatrix, Result_ListBox: Result_ListBox);
        }

        /// <summary>
        /// Отображение окна "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutProgram_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutProgram formAboutProgram = new FormAboutProgram();
            formAboutProgram.Show();
        }

        /// <summary>
        /// Ввод размера матрицы через окно ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatrixSize_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterForm enterForm = new EnterForm("Введите количество неизвестных:");
            enterForm.DataSubmitted += (data) =>
            {
                if (!int.TryParse(data, out int size))
                {
                    MessageBox.Show(text: "Некорректный ввод!",
                                caption: "Ошибка ввода",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                    );
                    return;
                }

                if (size <= 1 || size >= 16)
                {
                    MessageBox.Show(text: "Некорректный размер матрицы!",
                                    caption: "Ошибка ввода",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                    );
                    return;
                }

                SizeMatrix = size;
                NumberMatrix_NumericUpDown.Value = SizeMatrix;
                DataGridHelper.GenerateTable(Matrix_DataGridView: Matrix_DataGridView, size: SizeMatrix, Result_ListBox: Result_ListBox);
            };
            enterForm.ShowDialog();
        }

        /// <summary>
        /// Ввод матрицы через окно ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EnterMatrix_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Matrix_DataGridView.RowCount; i++)
            {
                for (int j = 1; j < Matrix_DataGridView.ColumnCount; j++)
                {
                    bool valueEntered = false;
                    string userInput = null;

                    while (!valueEntered)
                    {
                        var tcs = new TaskCompletionSource<string>();

                        EnterForm enterForm = new EnterForm($"Введите значение для ячейки:\nСтрока {i + 1}, Столбец {Matrix_DataGridView.Columns[j].HeaderText}");

                        enterForm.DataSubmitted += (value) =>
                        {
                            tcs.SetResult(value);
                        };

                        enterForm.ShowDialog();

                        userInput = await tcs.Task;

                        if (double.TryParse(userInput, out double result))
                        {
                            Matrix_DataGridView.Rows[i].Cells[j].Value = result;
                            valueEntered = true;
                        }
                        else
                        {
                            MessageBox.Show(text: "Некорректный ввод! Пожалуйста, введите число.",
                                caption: "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Отображение системы в графическом виде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Graph_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] clearMatrix = DataGridHelper.GetClearMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);

            if (clearMatrix != null)
            {
                GraphForm graphForm = new GraphForm(clearMatrix);
                graphForm.Show();
            }
        }

        /// <summary>
        /// Изменение цыета главной метки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColor_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog
            {
                AllowFullOpen = true
            };

            if (colorDialog1.ShowDialog() == DialogResult.OK)
                MainLabel.ForeColor = colorDialog1.Color;

            IniHelper.SaveIni(MainLabel.ForeColor);
        }

        /// <summary>
        /// Установка цвета по умолчанию главной метки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseColor_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainLabel.ForeColor = Color.FromArgb(253, 130, 6);
            IniHelper.SaveIni(MainLabel.ForeColor);
        }

        /// <summary>
        /// Загрузка определённой системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DefinedSystem_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberMatrix_NumericUpDown.Value = 3;
            SizeMatrix = (int)NumberMatrix_NumericUpDown.Value;
            DataGridHelper.GenerateDefinedSystem(Matrix_DataGridView);
        }

        /// <summary>
        /// Загрузка неопределённой системы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndefiniteSystem_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumberMatrix_NumericUpDown.Value = 3;
            SizeMatrix = (int)NumberMatrix_NumericUpDown.Value;
            DataGridHelper.GenerateIndefiniteSystem(Matrix_DataGridView);
        }

        /// <summary>
        /// Открытие help файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpFilePath = System.IO.Path.Combine(Application.StartupPath, "CourseworkHelp.chm");
            Help.ShowHelp(null, helpFilePath);
        }

        /// <summary>
        /// Запуск презентации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Presentation_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string presentationFilePath = System.IO.Path.Combine(Application.StartupPath, "Coursework.pptx");
            Reports.PresentationPowerPoint presentation = new PresentationPowerPoint();
            presentation.OpenPresentation(presentationFilePath);
            presentation.Exit();
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Установка цвета главной метки при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            MainLabel.ForeColor = IniHelper.LoadIni();
        }

        /// <summary>
        /// Расчёт и отображение определителя матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatrixDeterminant_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] squareMatrix = DataGridHelper.GetSquareMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);

            if (squareMatrix != null)
            {
                double determinant = matrix.Determinant(squareMatrix);
                MessageBox.Show(text: $"Определитель квадратной матрицы: {determinant}.",
                    caption: "Вычисления", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Расчёт и отображение обратной матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InverseMatrix_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] squareMatrix = DataGridHelper.GetSquareMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);

            double[,] inverseMatrix = matrix.InvertMatrix(squareMatrix);
            if (inverseMatrix == null)
            {
                MessageBox.Show(text: "Матрица необратима. Определитель равен 0.",
                                caption: "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                );
                return;
            }

            DisplayMatrix displayMatrix = new DisplayMatrix(operation: "Обратная матрица", matrix: inverseMatrix);
            displayMatrix.Show();
        }

        /// <summary>
        /// Расчёт и отображение транспонированной матрицы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatrixTransporation_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] squareMatrix = DataGridHelper.GetSquareMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);
            if (squareMatrix == null)
                return;

            double[,] transposeMatrix = matrix.TransposeMatrix(squareMatrix);

            DisplayMatrix displayMatrix = new DisplayMatrix(operation: "Транспонированная матрица", matrix: transposeMatrix);
            displayMatrix.Show();
        }

        /// <summary>
        /// Создание отчёта в Microsoft Word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportToWord_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] clearMatrix = DataGridHelper.GetClearMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);
            if (clearMatrix == null)
                return;

            DataGridHelper.CalculateMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix, matrixSolver: matrix);
            string[,] dataGrid = DataGridHelper.GetDataFromDataGridView(Matrix_DataGridView);
            var solutions = matrix.SolveGauss(clearMatrix);

            Task.Run(() =>
            {
                report = new Reports.ReportWord();
                Thread.Sleep(200);
                report.AddText("Метод Жордана-Гаусса");
                report.AddTable(dataGrid);
                report.AppendAnswers(solutions);
                report.Exit();
            });
        }

        /// <summary>
        /// Создание отчёта в Microsoft Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportToExcel_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double[,] clearMatrix = DataGridHelper.GetClearMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix);
            if (clearMatrix == null)
                return;

            DataGridHelper.CalculateMatrix(Matrix_DataGridView: Matrix_DataGridView, Result_ListBox: Result_ListBox, size: SizeMatrix, matrixSolver: matrix);
            var solutions = matrix.SolveGauss(clearMatrix);
            string[,] dataGrid = DataGridHelper.GetDataFromDataGridView(Matrix_DataGridView);

            Task.Run(() =>
            {
                report = new Reports.ReportExcel();
                Thread.Sleep(200);
                report.AddText("Метод Жордана-Гаусса");
                report.AddTable(dataGrid);
                report.AppendAnswers(solutions);
                report.Exit();
            }); 
        }
    }
}
