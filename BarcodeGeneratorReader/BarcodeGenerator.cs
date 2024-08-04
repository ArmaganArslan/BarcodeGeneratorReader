using System.Drawing;
using System.Drawing.Imaging;
using ZXing;

public static class BarcodeGenerator
{
    public static void GenerateAndSaveBarcode(string barcodeText, string filePath)
    {
        BarcodeWriter barcodeWriter = new BarcodeWriter
        {
            Format = BarcodeFormat.CODE_128,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 150
            }
        };

        using (Bitmap barcodeBitmap = barcodeWriter.Write(barcodeText))
        {
            FileHelper.EnsureDirectoryExists(filePath);
            barcodeBitmap.Save(filePath, ImageFormat.Png);
        }
    }
}
