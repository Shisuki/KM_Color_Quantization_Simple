using System;
using System.Drawing;



namespace KM_Color_Quantization_Simple
{
    class KmeansSimple : Kmeans
    {
        public event EventHandler<ImageEventArgs> ImageFinished;

        protected virtual void OnImageFinished(Bitmap image)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { imageProperty = image });
        }

        public Bitmap Compute(int k, object imageObject)
        {
            Bitmap image = (Bitmap)imageObject;
            Centroid[] centroid = new Centroid[k];
            double maxMin = Math.Pow(image.Width, 2) + Math.Pow(image.Height, 2);
            int cpt = 0;

            AssignClusters(k, centroid);

            while (cpt < 10)
            {
                FindNearestCentroids(image, k, centroid, maxMin);
                NewCentroidsPosition(k, centroid);
                Console.WriteLine("Iteration: {0}", cpt++);
            }
            
            NewPixelColors(image, k, centroid);

            //OnImageFinished(image);
            return image;
        }

        public void NewPixelColors(Bitmap image, int k, Centroid[] centroid)
        {
            Color pixelColor = new Color();

            for (int i = 0; i < k; i++)
            {
                pixelColor = Color.FromArgb(centroid[i].Red, centroid[i].Green, centroid[i].Blue);
                foreach (var pixel in centroid[i].cluster)
                {
                    image.SetPixel(pixel.x, pixel.y, pixelColor);
                }
            }
        }

        public void FindNearestCentroids(Bitmap image, int k, Centroid[] centroid, double maxMin)
        {
            Color pixelColor = new Color();
            double colorDistance = 0;
            double min = maxMin;
            int nearestCentroid = 0;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    colorDistance = 0;
                    min = maxMin;
                    nearestCentroid = 0;
                    pixelColor = image.GetPixel(x, y);

                    for (int i = 0; i < k; i++)
                    {
                        colorDistance =
                            Math.Pow(pixelColor.R - centroid[i].Red, 2) +
                            Math.Pow(pixelColor.G - centroid[i].Green, 2) +
                            Math.Pow(pixelColor.B - centroid[i].Blue, 2);

                        if (colorDistance < min)
                        {
                            min = colorDistance;
                            nearestCentroid = i;
                        }
                    }
                    var currentPixel = new Pixel(
                        x,
                        y,
                        pixelColor.R,
                        pixelColor.G,
                        pixelColor.B
                        );

                    centroid[nearestCentroid].cluster.Add(currentPixel);
                }
            }
        }
    }
}
