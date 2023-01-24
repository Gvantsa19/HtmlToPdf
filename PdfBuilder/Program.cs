
using PdfBuilder;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

PDFBuilder builder = new PDFBuilder();
builder.WithHeader("", 0, 0)
       .WithContent("", 0, 50)
       .WithFont(new PdfStandardFont(PdfFontFamily.Helvetica, 14))
       .WithFontColor(Color.Red)
       .Save("htmltopdf.pdf");
