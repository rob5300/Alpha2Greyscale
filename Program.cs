using System;
using System.Drawing;
using System.IO;

namespace Alpha2GreyscaleCore
{
    class Program
    {
        static string imagepath;

        static void Main(string[] args)
        {
            Console.WriteLine("Alpha2Greyscale by rob5300:");
            if (args.Length >= 1)
            {
                imagepath = args[0];
            }
            else
            {
                Console.WriteLine("No argument given! Exiting...");
                return;
            }

            try
            {
                Bitmap image = new Bitmap(imagepath);
                Bitmap convertedImage = new Bitmap(image.Width, image.Height);

                if (image != null)
                {
                    //Process the image. take the alpha component and create a new image.

                    for (int x = 0; x < image.Width; x++)
                    {
                        for (int y = 0; y < image.Height; y++)
                        {
                            Color pixel = image.GetPixel(x, y);
                            Color newColor = Color.FromArgb(pixel.A, pixel.A, pixel.A);
                            convertedImage.SetPixel(x, y, newColor);
                        }
                    }

                    //We are done. Save the image.

                    //Fix the filename to be without the extension
                    string newPath = Path.GetDirectoryName(imagepath) + "/" + Path.GetFileNameWithoutExtension(imagepath) + "Converted.png";

                    convertedImage.Save(newPath, image.RawFormat);
                    Console.WriteLine("Converted image saved to: " + newPath);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Conversion failed: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
