using System;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using ImageMagick;


namespace imgtopdfvv.functions
{
    internal class PdfToImage
    {
        public string _pdfPathInputPath { get; set; }
        private string _pdfPathOutputPath { get; set; }

        public void convertPdfToImage(string inputFileName, string imageFormat)
        {
            _pdfPathInputPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\pdftoimg\\ip_pdf\\" + inputFileName + ".pdf";

            if (!Directory.Exists(_pdfPathOutputPath))
                Console.WriteLine("Output directory does not exist");


            // ----------------------------------------------------------------------
            // 
            //using (var images = new MagickImageCollection())
            //{
            //    images.Read(_pdfPathInputPath);

            //    for (int i = 0; i < images.Count; i++)
            //    {
            //        _pdfPathOutputPath = Path.Combine(
            //            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\pdftoimg\\op_img"
            //            , $"{inputFileName}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}_page-{i + 1}.{imageFormat}");
            //        var image = images[i];

            //        image.Format = imageFormat == "png" ? MagickFormat.Png : MagickFormat.Jpeg;

            //        image.Write(_pdfPathOutputPath);
            //    }
            //}
            // ----------------------------------------------------------------------
        }
    }
}
