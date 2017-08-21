using System;
using System.Collections.Generic;
using System.Linq;


namespace KM_Color_Quantization_Simple
{
    class Kmeans
    {
        public struct Pixel
        {
            public int x;
            public int y;
            public byte Red;
            public byte Green;
            public byte Blue;

            public Pixel(int x, int y, byte red, byte green, byte blue)
            {
                this.x = x;
                this.y = y;
                Red = red;
                Green = green;
                Blue = blue;
            }
        }

        public struct Centroid
        {
            public byte Red;
            public byte Green;
            public byte Blue;
            public List<Pixel> cluster;

            public Centroid(byte red, byte green, byte blue, List<Pixel> cluster)
            {
                Red = red;
                Green = green;
                Blue = blue;
                this.cluster = cluster;
            }
        }

        public void NewCentroidsPosition(int k, Centroid[] centroid)
        {
            for (int i = 0; i < k; i++)
            {
                int pixelsNumber = centroid[i].cluster.Count();

                if (pixelsNumber > 0)
                {
                    int redSum = 0;
                    int greenSum = 0;
                    int blueSum = 0;

                    foreach (var pixel in centroid[i].cluster)
                    {
                        redSum += pixel.Red;
                        greenSum += pixel.Green;
                        blueSum += pixel.Blue;
                    }

                    centroid[i].Red = (byte)(redSum / pixelsNumber); // Mean of Red
                    centroid[i].Green = (byte)(greenSum / pixelsNumber); // Mean of Green
                    centroid[i].Blue = (byte)(blueSum / pixelsNumber); // Mean of Blue
                }
            }
        }

        public void AssignClusters(int k, Centroid[] centroid)
        {
            Random rand = new Random();

            for (int i = 0; i < k; i++)
            {
                centroid[i] = new Centroid(
                    (byte)rand.Next(256), //Red
                    (byte)rand.Next(256), //Green
                    (byte)rand.Next(256), //Blue
                    new List<Pixel>()     //Cluster
                    );
            }
        }
    }
}