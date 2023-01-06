using ConsoleApp.ConcreteBuilder;
using ConsoleApp;


//დინამიურად ქმნის pdf-ს ჩვენ მიერ გაწერილი
DynamicConverter ToPdf = new DynamicConverter();
ToPdf.Create();


//შემოსული html გადაყავს pdf ფორმატში
HtmlToPdfHelper.PdfSharpConvert(@"C:\\Users\\User\\Desktop\\HtmlConverter\\HtmlConverter\\Template\\index.html");