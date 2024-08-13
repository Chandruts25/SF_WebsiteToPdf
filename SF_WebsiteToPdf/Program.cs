using SF_WebsiteToPdf;
using Syncfusion.Drawing;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

Console.WriteLine("Hello, World!");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQwMDY4MEAzMjM2MmUzMDJlMzBEaXFOMHhrRy9aWEttTVoyVnMxZ2dFUFI3ZTBZbENDK2FxS21KdmY3aTBrPQ==");

string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
string inputFilePath = Path.Combine(projectDirectory, "InputFiles\\Urls.txt");
string outputPath = Path.Combine(projectDirectory, "OutputFiles");

int viewportWidth = 1366;
int viewportHeight = 0;

if (!File.Exists(inputFilePath))
{
    Console.WriteLine("File not found.");
    return;
}

string[] urls = File.ReadAllLines(inputFilePath);

if(!urls.Any())
{
    Console.WriteLine("No Urls found.");
    return;
}

BlinkConverterSettings settings = new BlinkConverterSettings();
settings.ViewPortSize = new Size(viewportWidth, viewportHeight);
settings.Margin.Top = 0;
settings.AdditionalDelay = 5000;
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

        using (FileStream stream = new FileStream($"{outputPath}\\outputFile{index++}.pdf", FileMode.Create, FileAccess.Write))
        {
            document.Save(stream);
        }

        document.Close(true); 
    }
}

Console.WriteLine("PDF saved successfully.");