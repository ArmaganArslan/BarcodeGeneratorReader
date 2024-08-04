using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ZXing;

namespace BarcodeGeneratorReader { 
class Program
{
        static void Main()
        {
            Console.Write("Barkod metnini girin: ");
            string barcodeText = Console.ReadLine();

            string filePath = @"C:\Barkodlar\barcode.png";

            BarcodeGenerator.GenerateAndSaveBarcode(barcodeText, filePath);
            Console.WriteLine($"Barkod '{filePath}' dosyasına kaydedildi.");

            string result = BarcodeReaderHelper.ReadBarcode(filePath);
            Console.WriteLine(result);

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}