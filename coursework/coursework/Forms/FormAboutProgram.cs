using System;
using System.Windows.Forms;

namespace coursework
{
    /// <summary>
    /// Класс отображения информации о программе
    /// </summary>
    public partial class FormAboutProgram : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormAboutProgram()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
