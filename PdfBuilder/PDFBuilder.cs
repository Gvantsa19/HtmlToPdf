using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace PdfBuilder
{
    public class PDFBuilder
    {
        private PdfDocument document;
        private PdfPage page;
        private PdfGraphics graphics;
        private PdfFont font;
        private PdfBrush brush;
        private PdfGrid grid;

        public PDFBuilder()
        {
            document = new PdfDocument();
            page = document.Pages.Add();
            graphics = page.Graphics;
        }

        public PDFBuilder WithHeader(string text, float x, float y)
        {
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 24);
            brush = new PdfSolidBrush(Color.Black);
            graphics.DrawString(text, font, brush, new PointF(x, y));
            return this;
        }

        public PDFBuilder WithContent(string text, float x, float y)
        {
            font = new PdfStandardFont(PdfFontFamily.Helvetica, 12);
            brush = new PdfSolidBrush(Color.Black);
            graphics.DrawString(text, font, brush, new PointF(x, y));
            return this;
        }

        public PDFBuilder WithFont(PdfFont font)
        {
            this.font = font;
            return this;
        }

        public PDFBuilder WithFontColor(Color color)
        {
            brush = new PdfSolidBrush(color);
            return this;
        }

        //public PDFBuilder CreateGrid(int colCount, int rowCount)
        //{
        //    grid = new PdfGrid();
        //    grid.Columns.Add(colCount);
        //    grid.Rows.Add(rowCount);
        //    return this;
        //}

        public PDFBuilder AddGridData(string[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    grid.Rows[i].Cells[j].Value = data[i, j];
                }
            }
            return this;
        }

        public PDFBuilder DrawGrid(float x, float y)
        {
            grid.Draw(page, new PointF(x, y));
            return this;
        }

        public PDFBuilder AddImage(string imagePath, float x, float y)
        {
            using (FileStream stream = File.OpenRead(imagePath))
            {
                PdfBitmap image = new PdfBitmap(stream);
                graphics.DrawImage(image, x, y);
            }
            return this;
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
