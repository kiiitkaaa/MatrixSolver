using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace Reports
{
    /// <summary>
    /// Работа с Microsoft PowerPoint
    /// </summary>
    public class PresentationPowerPoint
    {
        private PowerPoint.Application pptApp;
        private PowerPoint.Presentation presentation;

        /// <summary>
        /// Открытие презентации
        /// </summary>
        /// <param name="filePath"></param>
        public void OpenPresentation(string filePath)
        {
            pptApp = new PowerPoint.Application();
            pptApp.Visible = MsoTriState.msoTrue;

            presentation = pptApp.Presentations.Open(
                filePath,
                WithWindow: MsoTriState.msoTrue
            );
        }

        /// <summary>
        /// Освобождение COM-ресурсов
        /// </summary>
        public void Exit()
        {
            if (presentation != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(presentation);
            if (pptApp != null)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(pptApp);
        }
    }
}
