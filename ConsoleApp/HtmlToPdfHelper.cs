﻿using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;


namespace ConsoleApp
{
    public class HtmlToPdfHelper
    {
        public void PdfSharpConvert(string html)
        {
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

            PdfDocument document = htmlConverter.Convert(Path.GetFullPath(html));

            FileStream fileStream = new FileStream("PDF3.pdf", FileMode.CreateNew, FileAccess.ReadWrite);

            document.Save(fileStream);
            document.Close(true);
        }

    }
}
