using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KM_Color_Quantization_Simple
{
    class FileOpening
    {
        Bitmap image;

        public Bitmap OpenFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:/Images";
            open.Filter = "images| *.jpg; *.jpeg; *.png;";

            if (open.ShowDialog() == DialogResult.OK)
                image = new Bitmap(Image.FromFile(open.FileName));

            return image;
        }

    }
}
