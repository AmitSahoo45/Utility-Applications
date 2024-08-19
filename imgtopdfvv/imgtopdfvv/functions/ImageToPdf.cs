using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace imgtopdfvv.functions
{
    internal class ImageToPdf
    {
        private void convertImageToPdf(string[] imagePaths, string outputFileName)
        {
            using (PdfDocument doc = new PdfDocument())
            {
                foreach (var imagePath in imagePaths)
                {
                    PdfPage page = doc.AddPage();

                    using (XGraphics gfx = XGraphics.FromPdfPage(page))
                    {
                        using (var image = Image.Load(imagePath))
                        {
                            double xRatio = page.Width / image.Width;
                            double yRatio = page.Height / image.Height;
                            double ratio = Math.Min(xRatio, yRatio);

                            double width = image.Width * ratio;
                            double height = image.Height * ratio;

                            double x = (page.Width - width) / 2;
                            double y = (page.Height - height) / 2;

                            gfx.DrawImage(XImage.FromFile(imagePath), x, y, width, height);
                        }
                    }
                }

                doc.Save(outputFileName);
            }
        }
    }
}
