using SF_WebsiteToPdf;
using Syncfusion.Drawing;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

Console.WriteLine("Hello, World!");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQwMDY4MEAzMjM2MmUzMDJlMzBEaXFOMHhrRy9aWEttTVoyVnMxZ2dFUFI3ZTBZbENDK2FxS21KdmY3aTBrPQ==");

string filePath = "C:\\Users\\chandru.ts\\Desktop\\Urls.txt";
int viewportWidth = 1366;
int viewportHeight = 0;

if (!File.Exists(filePath))
{
    Console.WriteLine("File not found.");
    return;
}

string[] urls = File.ReadAllLines(filePath);

if(!urls.Any())
{
    Console.WriteLine("No Urls found.");
    return;
}

BlinkConverterSettings settings = new BlinkConverterSettings();
settings.ViewPortSize = new Size(viewportWidth, viewportHeight);
settings.Margin.Top = 0;
settings.MediaType = MediaType.Screen;
settings.Css = CustomStyle.customCss;

HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();
htmlConverter.ConverterSettings = settings;

var index = 1;

foreach (var url in urls)
{
    if (!string.IsNullOrWhiteSpace(url))
    {
        PdfDocument document = htmlConverter.Convert(url);

        using (FileStream stream = new FileStream($"C:\\Users\\chandru.ts\\Downloads\\outputFile{index++}.pdf", FileMode.Create, FileAccess.Write))
        {
            document.Save(stream);
        }

        document.Close(true); 
    }
}

Console.WriteLine("PDF saved successfully.");