using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace coursework.Forms
{
    /// <summary>
    /// Класс для отображения матрицы в графическом виде
    /// </summary>
    public partial class GraphForm : Form
    {
        private readonly double[,] matrix;
        private Thread graphThread;
        private readonly Panel panel;
        private bool drawLastColumn = false;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="matrix">Расширенная матрица</param>
        public GraphForm(double[,] matrix)
        {
            InitializeComponent();

            Text = "График";
            panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Gray
            };
            panel.Paint += Panel_Paint;
            Controls.Add(panel);

            this.matrix = matrix;
        }

        /// <summary>
        /// Запуск потока для рисования при загрузке окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphForm_Load(object sender, EventArgs e)
        {
            if (matrix == null) return;

            graphThread = new Thread(() =>
            {
                while (true)
                {
                    panel.Invoke((MethodInvoker)(() => panel.Invalidate()));
                    Thread.Sleep(1000);
                    drawLastColumn = true;
                    panel.Invoke((MethodInvoker)(() => panel.Invalidate()));
                    Thread.Sleep(1000);
                }
            });
            graphThread.IsBackground = true;
            graphThread.Start();
        }

        /// <summary>
        /// Обработчик события отрисовки панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            if (matrix == null) return;

            Graphics g = e.Graphics;
            DrawMainMatrix(g);

            if (drawLastColumn)
                DrawLastColumn(g);
        }

        /// <summary>
        /// Отрисовка квадратной матрицы
        /// </summary>
        /// <param name="g"></param>
        private void DrawMainMatrix(Graphics g)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1) - 1;
            int cellSize = Math.Min(panel.Width / matrix.GetLength(1), panel.Height / rows);

            using (Font font = new Font("Arial", 10))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Rectangle rect = new Rectangle(col * cellSize, row * cellSize, cellSize, cellSize);

                        using (Brush brush = new SolidBrush(Color.DarkOrange))
                            g.FillRectangle(brush, rect);

                        g.DrawRectangle(Pens.Black, rect);

                        string text = matrix[row, col].ToString("0.##");
                        TextRenderer.DrawText(g, text, font, rect, Color.Black,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }
                }
            }
        }

        /// <summary>
        /// Отрисовка расширенной матрицы
        /// </summary>
        /// <param name="g"></param>
        private void DrawLastColumn(Graphics g)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1) - 1;
            int cellSize = Math.Min(panel.Width / matrix.GetLength(1), panel.Height / rows);

            using (Font font = new Font("Arial", 10))
            {
                for (int row = 0; row < rows; row++)
                {
                    Rectangle rect = new Rectangle(col * cellSize, row * cellSize, cellSize, cellSize);

                    using (Brush brush = new SolidBrush(Color.Tomato))
                        g.FillRectangle(brush, rect);

                    g.DrawRectangle(Pens.Black, rect);

                    string text = matrix[row, col].ToString("0.##");
                    TextRenderer.DrawText(g, text, font, rect, Color.Black,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }

            drawLastColumn = false;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            graphThread.Abort();
        }
    }
}
