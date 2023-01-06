using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using ConsoleApp.Model;

namespace ConsoleApp.Builder
{
    public abstract class IBuilder
    {
        protected Html html;

        public abstract PdfLayoutResult HeaderPoints(string text, float yPosition, PdfPage page);
        public abstract PdfLayoutResult BodyContent(string text, float yPosition, PdfPage page);


        public void CreateNewHtml()
        {
            html = new Html();
        }
        public Html GetHtml()
        {
            return html;
        }
    }
}
