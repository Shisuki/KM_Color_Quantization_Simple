using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace KM_Color_Quantization_Simple
{
    class KmeansSimple_LockBits : Kmeans
    {
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch stopWatch2 = new Stopwatch();

        public Bitmap Compute(int k, object imageObject)
        {
            Bitmap image = (Bitmap)imageObject;
            Centroid[] centroid = new Centroid[k];
            BitmapData bitmapData = 
                image.LockBits(
                    new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadOnly,
                    image.PixelFormat
                    );

            double maxMin = image.Width * image.Width + image.Height * image.Height;
            int cpt = 0;

            AssignClusters(k, centroid); //Step 1

            stopWatch.Start();
            while (cpt < 30)
            {
                stopWatch2.Start();

                FindNearestCentroids(image,bitmapData, k, centroid, maxMin); //Step 2
                NewCentroidsPosition(k, centroid); //Step 3

                Console.WriteLine("Iteration: {0} | {1}ms", cpt++, stopWatch2.ElapsedMilliseconds);
                stopWatch2.Reset();
            }
            image.UnlockBits(bitmapData);

            Console.WriteLine("Total Calculations Time : {0}ms",stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            stopWatch.Start();

            NewPixelColors(image, k, centroid); //Step 4

            Console.WriteLine("NewPixelColors Time : {0}ms", stopWatch.ElapsedMilliseconds);
            stopWatch.Reset();

            return image;
        }

        public void NewPixelColors(Bitmap image, int k, Centroid[] centroid)
        {
            BitmapData bitmapData =
                image.LockBits(
                    new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.WriteOnly,
                    image.PixelFormat
                    );

            int bytesPerPixel = Bitmap.GetPixelFormatSize(image.PixelFormat) / 8;

            unsafe
            {
                byte* pointerOnFirstPixel = (byte*)bitmapData.Scan0;
                for (int i = 0; i < k; i++)
                {
                    foreach (var pixel in centroid[i].cluster)
                    {
                        byte* currentLine = pointerOnFirstPixel + (pixel.y * bitmapData.Stride);

                        currentLine[pixel.x + 2] = centroid[i].Red;           // Red
                        currentLine[pixel.x + 1] = centroid[i].Green;        // Green
                        currentLine[pixel.x] = centroid[i].Blue;            // Blue
                    }
                }
            }
            image.UnlockBits(bitmapData);
        }

        public void FindNearestCentroids(Bitmap image, BitmapData bitmapData, int k, Centroid[] centroid, double maxMin )
        {
            double colorDistance = 0f;
            double min = maxMin;
            int nearestCentroid = 0;
            int bytesPerPixel = Bitmap.GetPixelFormatSize(image.PixelFormat) / 8;
            int heighInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;

            unsafe
            {
                byte* pointerOnFirstPixel = (byte*)bitmapData.Scan0;

                for (int y = 0; y < heighInPixels; y++)
                {
                    byte* currentLine = pointerOnFirstPixel + (y * bitmapData.Stride);

                    for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                    {
                        var currentPixel = 
                            new Pixel(
                                x,                          // X coordinate or First byte of the pixel we're at
                                y,                          // Y coordinate or the vertical row we're at
                                currentLine[x + 2],         // Red
                                currentLine[x + 1],         // Green
                                currentLine[x]              // Blue
                            );

                        colorDistance = 0;
                        min = maxMin;
                        nearestCentroid = 0;

                        if (x % bytesPerPixel == 0) //To get the exact X coordinate, since there's "bytesPerPixel" bytes in every pixel
                        {
                            for (int i = 0; i < k; i++)
                            {
                                //Calculating the squared euclidean distance between the two colors of the current pixel and each centroid
                                colorDistance = 
                                    (currentPixel.Red - centroid[i].Red) * (currentPixel.Red - centroid[i].Red) +
                                    (currentPixel.Green - centroid[i].Green) * (currentPixel.Green - centroid[i].Green) +
                                    (currentPixel.Blue - centroid[i].Blue) * (currentPixel.Blue - centroid[i].Blue);

                                if (colorDistance < min)
                                {
                                    min = colorDistance;
                                    nearestCentroid = i;
                                }
                            }
                            centroid[nearestCentroid].cluster.Add(currentPixel);
                        }
                    }
                }
            }
        }
    }
}
