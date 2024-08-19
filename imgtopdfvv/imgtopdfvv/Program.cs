using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imgtopdfvv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter 1 to convert PDF to Image");
                Console.WriteLine("Enter 2 to convert Image to PDF");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                   case 1:
                        Console.WriteLine("Enter the PDF file name");
                        string pdfFileName = Console.ReadLine();
                        Console.WriteLine("Enter the image format (png/jpeg)");
                        string imageFormat = Console.ReadLine();
                        functions.PdfToImage pdfToImage = new functions.PdfToImage();
                        pdfToImage.convertPdfToImage(pdfFileName, imageFormat);
                        break;

                    case 2:
                        Console.WriteLine("Enter the number of images to convert to PDF");
                        //int numberOfImages = Convert.ToInt32(Console.ReadLine());
                        //string[] imagePaths = new string[numberOfImages];
                        //for (int i = 0; i < numberOfImages; i++)
                        //{
                        //    Console.WriteLine($"Enter the path of image {i + 1}");
                        //    imagePaths[i] = Console.ReadLine();
                        //}
                        //Console.WriteLine("Enter the output PDF file name");
                        //string outputFileName = Console.ReadLine();
                        //functions.ImageToPdf imageToPdf = new functions.ImageToPdf();
                        //imageToPdf.convertImageToPdf(imagePaths, outputFileName);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.ReadLine();
            } while (true);
        }
    }
}
