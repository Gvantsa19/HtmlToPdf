
using PdfBuilder;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Graphics;

//PDFBuilder builder = new PDFBuilder();
//builder.WithHeader("", 0, 0)
//       .WithContent("", 0, 50)
//       .WithFont(new PdfStandardFont(PdfFontFamily.Helvetica, 14))
//       .WithFontColor(Color.Red)
//       .Save("htmltopdf.pdf");

Builder builder = new Builder();
builder.WithHeader("", 0, 0)
        .WithFont(new PdfStandardFont(PdfFontFamily.Helvetica, 14))
        .WithFontColor(Color.Red);
Wrapper wrapper = builder.Build();
wrapper.AddPage("", 0, 0);
wrapper.Save("html.pdf");
