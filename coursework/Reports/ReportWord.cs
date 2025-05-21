using System.Collections.Generic;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;

namespace Reports
{
   /// <summary>
   /// Создание отчёта в Microsoft Word
   /// </summary>
    public class ReportWord : IReport
    {
        private readonly Word.Application wordApp;
        private readonly Word.Document document;
        private int currentParagraph = 1;

        public ReportWord()
        {
            wordApp = new Word.Application();
            wordApp.Visible = false;
            document = wordApp.Documents.Add();
        }

        public void AddText(string text)
        {
            Thread.Sleep(500);
            Word.Paragraph para = document.Paragraphs.Add();
            para.Range.Text = text;
            currentParagraph += 2;
        }

        public void AddTable(string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            Thread.Sleep(500);
            Word.Range range = document.Content;
            range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            Thread.Sleep(500);
            Word.Table table = document.Tables.Add(range, rows, cols);
            table.Borders.Enable = 1;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    table.Cell(i + 1, j + 1).Range.Text = data[i, j];
        }

        public void AppendAnswers(List<string> answers)
        {
            Thread.Sleep(500);
            Word.Range range = document.Content;
            range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);

            range.InsertParagraphAfter();
            range.InsertAfter("Решение:\n");

            foreach (string answer in answers)
            {
                range.InsertParagraphAfter();
                range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
                range.InsertAfter(answer + "\n");
            }
        }

        public void Exit()
        {
            wordApp.Visible = true;
            if (document != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(document);
            if (wordApp != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
        }
    }
}
