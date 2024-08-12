using Syncfusion.Drawing;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

Console.WriteLine("Hello, World!");

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQwMDY4MEAzMjM2MmUzMDJlMzBEaXFOMHhrRy9aWEttTVoyVnMxZ2dFUFI3ZTBZbENDK2FxS21KdmY3aTBrPQ==");

//string url = "https://firstsiteguide.com/examples-of-blogs/#lifestyle-blogs";
string url = "https://qadentsource.com/Products/DentaQual/ScoreCardExt/13158625-646D-4657-9EA0-97DC1C2BC9BB/7A5CF855-4390-46F2-826F-04690DA9A932/2323232";

// Initialize the HTML to PDF converter
HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter();

int viewportWidth = 1366;
int viewportHeight = 0;

// Set the Blink converter settings
BlinkConverterSettings settings = new BlinkConverterSettings();
settings.ViewPortSize = new Size(viewportWidth, viewportHeight);
//settings.Margin = new Syncfusion.Pdf.Graphics.PdfMargins();

settings.Css = @"
    .row { display: flex; flex-wrap: wrap; }
    .col-md-6, .col-md-12, .col-sm-12 { flex: 0 0 50%; max-width: 50%; }
    body { margin: 0; }
";

// Use screen media type
settings.MediaType = MediaType.Screen;
htmlConverter.ConverterSettings = settings;


// Convert the URL to a PDF document
PdfDocument document = htmlConverter.Convert(url);

// Save the PDF document to a file using FileStream
using (FileStream stream = new FileStream("C:\\Users\\chandru.ts\\Downloads\\output.pdf", FileMode.Create, FileAccess.Write))
{
    document.Save(stream);
}

// Close the document
document.Close(true);

Console.WriteLine("PDF saved successfully.");