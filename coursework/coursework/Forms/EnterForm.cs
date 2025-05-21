using System;
using System.Windows.Forms;

namespace coursework
{
    /// <summary>
    /// Класс для ввода значений в отдельной форме
    /// </summary>
    public partial class EnterForm : Form
    {
        /// <summary>
        /// Событие ввода
        /// </summary>
        public event Action<string> DataSubmitted;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parametr">Тип вводимого параметра</param>
        public EnterForm(string parametr)
        {
            InitializeComponent();

            Parametr_Label.Text = parametr;
        }

        /// <summary>
        /// Ввод значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            string data = Enter_TextBox.Text;
            DataSubmitted?.Invoke(data);
            Close();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
