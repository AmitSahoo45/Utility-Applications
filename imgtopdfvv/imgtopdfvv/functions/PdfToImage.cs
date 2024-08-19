using System;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Png;


namespace imgtopdfvv.functions
{
    internal class PdfToImage
    {
        private string _pdfPathInputPath = "/pdftoimg/ip_pdf";
        private string _pdfPathOutputPath = "/pdftoimg/op_pdf";

        public void convertPdfToImage(string inputFileName, string imageFormat)
        {
            _pdfPathInputPath += inputFileName;
            using (PdfDocument doc = PdfReader.Open(_pdfPathInputPath, PdfDocumentOpenMode.ReadOnly))
            {
                for (int i = 0; i < doc.PageCount; ++i)
                {
                    var page = doc.Pages[i];

                    using (var image = new Image<Rgba32>(((int)page.Width.Point), ((int)page.Height.Point)))
                    {
                        if (imageFormat == "png")
                            image.SaveAsPng(Path.Combine(_pdfPathOutputPath, $"{inputFileName}_{DateTime.Now.ToShortTimeString()}_page-{i + 1}.png"));
                        else
                            image.SaveAsJpeg(Path.Combine(_pdfPathOutputPath, $"{inputFileName}_{DateTime.Now.ToShortTimeString()}_page-{i + 1}.jpeg"));
                    }
                }
            }
        }
    }
}
