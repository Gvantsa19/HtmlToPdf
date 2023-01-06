using ConsoleApp.Builder;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace ConsoleApp.ConcreteBuilder
{
    public class DynamicConverter : IBuilder
    {
        //ფერები     
        Color gray = Color.FromArgb(255, 77, 77, 77);
        Color black = Color.FromArgb(255, 0, 0, 0);
        Color white = Color.FromArgb(255, 255, 255, 255);
        Color violet = Color.FromArgb(255, 151, 108, 174);
        public override PdfLayoutResult BodyContent(string text, float yPosition, PdfPage page)
        {
            throw new NotImplementedException();
        }

        public override PdfLayoutResult HeaderPoints(string text, float yPosition, PdfPage page)
        {
            throw new NotImplementedException();
        }
    }
}
