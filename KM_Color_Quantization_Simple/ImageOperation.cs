using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace KM_Color_Quantization_Simple
{
    class ImageOperation
    {
        public event EventHandler<ImageEventArgs> ImageFinished;

        protected virtual void OnImageFinished(Bitmap image)
        {
            ImageFinished?.Invoke(this, new ImageEventArgs() { imageProperty = image });
        }

        public void RemoveBlue(object imageObject)
        {
            Bitmap image = (Bitmap)imageObject;

            Color pixelColor = new Color();
            Color newPixelColor = new Color();

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    pixelColor = image.GetPixel(x, y);

                    newPixelColor = Color.FromArgb(pixelColor.R, pixelColor.G, 0);

                    image.SetPixel(x, y, newPixelColor);
                }
            }
            OnImageFinished(image);

        }

        public void RemoveBlue_LockBit(object imageObject)
        {
            Bitmap image = (Bitmap)imageObject;
            unsafe
            {
                BitmapData bitmapData = image.LockBits(
                    new Rectangle(0, 0, image.Width, image.Height),
                    ImageLockMode.ReadWrite,
                    image.PixelFormat);

                int bytesPerPixel = Bitmap.GetPixelFormatSize(image.PixelFormat) / 8;
                int heighInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;

                byte* pointerOnFirstPixel = (byte*)bitmapData.Scan0;

                Parallel.For(0, heighInPixels, y =>
                {
                    byte* currentLine = pointerOnFirstPixel + (y * bitmapData.Stride);

                    for (int x = 0; x < widthInBytes; x += bytesPerPixel)
                    {
                        int Blue = currentLine[x];
                        int Green = currentLine[x + 1];
                        int Red = currentLine[x + 2];

                        currentLine[x] = 0;
                        currentLine[x + 1] = (byte)Green;
                        currentLine[x + 2] = (byte)Red;
                    }
                });
                image.UnlockBits(bitmapData);
            }

            OnImageFinished(image);
        }
    }
}
