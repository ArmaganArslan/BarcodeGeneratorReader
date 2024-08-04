using System.Drawing;
using ZXing;

public static class BarcodeReaderHelper
{
    public static string ReadBarcode(string filePath)
    {
        using (Bitmap bitmap = new Bitmap(filePath))
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            return result != null ? $"Barkod okundu: {result.Text}" : "Barkod okunamadı.";
        }
    }
}
