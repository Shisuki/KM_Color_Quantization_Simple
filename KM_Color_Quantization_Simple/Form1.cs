using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace KM_Color_Quantization_Simple
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        Bitmap image;
        FileOpening getFile = new FileOpening();
        ImageOperation modifyImage = new ImageOperation();
        KmeansSimple kMeansSimple = new KmeansSimple();
        KmeansSimple_LockBits kMeansSimpleLockbits = new KmeansSimple_LockBits();


        public Form1()
        {
            InitializeComponent();
            modifyImage.ImageFinished += OnImageFinished;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        delegate void SetTextCallback(string text, Label label);

        private void SetText(string text, Label label)
        {
            if (label.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { text, label });
            }
            else
            {
                label.Text = text;
            }
        }

        public void DisplayImage(Bitmap image, int box)
        {
            if (box == 1)
            {
                pictureBox1.Image = image;
                pictureBox2.Image = null;
                if (image.Width < pictureBox1.Width && image.Height < pictureBox1.Height)
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                else
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (box == 2)
            {
                pictureBox2.Image = image;
                if (image.Width < pictureBox2.Width && image.Height < pictureBox2.Height)
                    pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
                else
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void OnImageFinished(object sender, ImageEventArgs e)
        {
            stopWatch.Stop();
            SetText(stopWatch.ElapsedMilliseconds + "ms", timeLabel_val);
            stopWatch.Reset();
            
            DisplayImage(e.imageProperty, 2);
        }

        private void OpenImage_btn_Click(object sender, EventArgs e)
        {
            image = getFile.OpenFile();
            if (image != null)
            {
                DisplayImage(image, 1);

                timeLabel_val.Text = "";

                resLabel_val.Text = image.Width + "x" + image.Height;

                pixelsLabel_val.Text =
                    (image.Width * image.Height) >= 1000000
                    ?
                    ((image.Width * image.Height) / 1000000) + "M"
                    :
                    (image.Width * image.Height) + "";
            }
        }

        private void ModifyImage_btn_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            Thread thread = new Thread(new ParameterizedThreadStart(modifyImage.RemoveBlue));
            thread.Start(image);
        }

        private void LockBit_btn_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            Thread thread = new Thread(new ParameterizedThreadStart(modifyImage.RemoveBlue_LockBit));
            thread.Start(image);
        }

        private void kMeansSimple_btn_Click(object sender, EventArgs e)
        {
            //stopWatch.Start();
            Thread thread = new Thread(() => DisplayImage(kMeansSimple.Compute((int)K_Value.Value, image), 2));
            thread.Start();
        }

        private void kMeansSimpleLockbits_btn_Click(object sender, EventArgs e)
        {
            //stopWatch.Start();
            Thread thread = new Thread(() => DisplayImage(kMeansSimpleLockbits.Compute((int)K_Value.Value, image), 2));
            thread.Start();
        }
    }
}
