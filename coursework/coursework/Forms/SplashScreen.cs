using System;
using System.Windows.Forms;

namespace coursework
{
    /// <summary>
    /// Класс заставки
    /// </summary>
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Таймер для открытия главного окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSplashScreen_Tick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            TimerSplashScreen.Stop();
            Hide();
        }
    }
}
