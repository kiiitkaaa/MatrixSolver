using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;

namespace Reports
{
    /// <summary>
    /// Создание отчёта в Microsoft Excel
    /// </summary>
    public class ReportExcel : IReport
    {
        private readonly Excel.Application excelApp;
        private readonly Excel.Workbook workbook;
        private readonly Excel.Worksheet worksheet;
        private int currentRow = 1;

        public ReportExcel()
        {
            excelApp = new Excel.Application();
            excelApp.Visible = true;
            workbook = excelApp.Workbooks.Add();
            worksheet = workbook.ActiveSheet;
        }

        public void AddText(string text)
        {
            Thread.Sleep(4000);
            worksheet.Cells[currentRow, 1] = text;
            currentRow += 2;
        }

        public void AddTable(string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            object[,] values = new object[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    values[i, j] = data[i, j];

            Excel.Range startCell = worksheet.Cells[currentRow, 1];
            Excel.Range endCell = worksheet.Cells[currentRow + rows - 1, cols];
            Excel.Range writeRange = worksheet.Range[startCell, endCell];

            try
            {
                Thread.Sleep(100);
                writeRange.Value2 = values;
            }
            catch (COMException ex)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка при записи в Excel: " + ex.Message);
            }

            currentRow += rows + 2;
        }

        public void AppendAnswers(List<string> answers)
        {
            Thread.Sleep(500);
            worksheet.Cells[currentRow, 1] = "Решение:";
            currentRow++;
            Thread.Sleep(50);
            foreach (string answer in answers)
            {
                worksheet.Cells[currentRow++, 1] = answer;
            }

            currentRow += 2;
        }

        public void Exit()
        {
            if (worksheet != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);

            if (workbook != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            }
        }
    }
}
