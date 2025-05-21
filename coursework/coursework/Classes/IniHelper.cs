using IniParser;
using IniParser.Model;
using System.Drawing;
using System.Windows.Forms;

namespace coursework.Classes
{
    /// <summary>
    /// Класс для работы с ini-файлами
    /// </summary>
    public static class IniHelper
    {
        private static readonly FileIniDataParser parser = new FileIniDataParser();
        private static readonly string iniFilePath = "settings.ini";

        /// <summary>
        /// Сохранение настроек цвета метки в файл
        /// </summary>
        /// <param name="labelColor">Цвет метки для сохранения</param>
        public static void SaveIni(Color labelColor)
        {
            IniData data = new IniData();
            Color color = labelColor;
            string colorString = $"{color.R},{color.G},{color.B}";
            data["Label"]["Color"] = colorString;
            parser.WriteFile(iniFilePath, data);
        }

        /// <summary>
        /// Загрузка цвета из файла
        /// </summary>
        /// <returns>Цвет метки</returns>
        public static Color LoadIni()
        {
            if (System.IO.File.Exists(iniFilePath))
            {
                IniData data = parser.ReadFile(iniFilePath);
                string colorString = data["Label"]["Color"];

                if (!string.IsNullOrWhiteSpace(colorString))
                {
                    string[] parts = colorString.Split(',');
                    if (parts.Length == 3 &&
                        int.TryParse(parts[0], out int r) &&
                        int.TryParse(parts[1], out int g) &&
                        int.TryParse(parts[2], out int b))
                    {
                        return Color.FromArgb(r, g, b);
                    }
                }
            }
            MessageBox.Show(caption: "Ошибка", text: "Ошибка чтения ini-файла");
            return Color.FromArgb(253, 130, 6);
        }
    }
}
