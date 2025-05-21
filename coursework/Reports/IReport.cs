using System.Collections.Generic;

namespace Reports
{
    /// <summary>
    /// Интерфейс с методами для создания отчётов через Microsoft Office
    /// </summary>
    public interface IReport
    {
        /// <summary>
        /// Добавление текств
        /// </summary>
        /// <param name="text">Текст</param>
        void AddText(string text);

        /// <summary>
        /// Создание таблицы
        /// </summary>
        /// <param name="data">Таблица</param>
        void AddTable(string[,] data);

        /// <summary>
        /// Добавление ответов решения
        /// </summary>
        /// <param name="answers">Список с ответами</param>
        void AppendAnswers(List<string> answers);

        /// <summary>
        /// Освобождение COM-ресурсов
        /// </summary>
        void Exit();
    }
}
