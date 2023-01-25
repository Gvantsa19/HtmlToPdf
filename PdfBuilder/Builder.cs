using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf;
using Syncfusion.Drawing;

namespace PdfBuilder
{
    public class Builder
    {
        private PdfDocument document;
        private PdfPage page;
        private PdfGraphics graphics;
        private PdfFont font;
        private PdfBrush brush;

        public Builder()
        {
            document = new PdfDocument();
        }

        public Builder WithHeader(string text, float x, float y)
        {
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            brush = new PdfSolidBrush(Color.Black);
            return this;
        }

        public Builder WithFont(PdfFont font)
        {
            this.font = font;
            return this;
        }

        public Builder WithFontColor(Color color)
        {
            brush = new PdfSolidBrush(color);
            return this;
        }

        public Wrapper Build()
        {
            page = document.Pages.Add();
            graphics = page.Graphics;
            return new Wrapper(document, font, brush);
        }
    }

    public class Wrapper
    {
        private PdfDocument document;
        private PdfFont font;
        private PdfBrush brush;

        public Wrapper(PdfDocument document, PdfFont font, PdfBrush brush)
        {
            this.document = document;
            this.font = font;
            this.brush = brush;
        }

        public void AddPage(string text, float x, float y)
        {
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;
            graphics.DrawString(text, font, brush, new PointF(x, y));
        }

        public void Save(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                document.Save(stream);
            }
            document.Close(true);
        }
    }
}
