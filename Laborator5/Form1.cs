using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator5
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> My_Image = null;

        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        Rectangle rect; Point StartROI; bool MouseDown;
        //private static VideoCapture cameraCapture;
        //private Image<Bgr, Byte> newBackgroundImage;
        //private static IBackgroundSubtractor fgDetector;

        public object Rotate_image { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

      
        private void IncarcareImagini_Click(object sender, EventArgs e) //afisare imagine
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if(Openfile.ShowDialog()== DialogResult.OK)
            {
                My_Image = new Image<Bgr, Byte>(Openfile.FileName);
                pictureBox2.Image = My_Image.ToBitmap();
            }
        }

        private void AlbNegru_Click(object sender, EventArgs e) //convert to gray
        {
                pictureBox1.Image = Metode.convertToGray(My_Image).AsBitmap();

        }

        private void Rotate_Click(object sender, EventArgs e)// contrast
        {
            string a = numericUpDown1.Text;
            float alfa = float.Parse(a);
            a = numericUpDown2.Text;
            int beta = int.Parse(a);
            pictureBox1.Image = Metode.Contrast(My_Image, alfa, beta).AsBitmap();
        }

        private void Gamma_Click(object sender, EventArgs e) //gamma
        {
            pictureBox1.Image = Metode.Gamma(My_Image, 20).AsBitmap();
        }

        private void Histogram_Click_1(object sender, EventArgs e) // histogram
        {
            HistogramViewer v = new HistogramViewer();
            v.HistogramCtrl.GenerateHistograms(My_Image, 255);
            v.Show();
        }

        private void resize(object sender, EventArgs e) // resize
        {
            
            pictureBox1.Image = Metode.Resize(My_Image,2).AsBitmap();
        }

        private void rotate(object sender, EventArgs e) //rotate
        {
            pictureBox1.Image = (Metode.Rotate(My_Image, 90)).AsBitmap();

        }

        private void Video_capture(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                pictureBox7.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;
                numericUpDown1.Value = FrameNo;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = TotalFrame;

                if (capture == null)
                {
                    return;
                }
                IsReadingFrame = true;
                ReadAllFrames();

            }
        }

        private async void BlendingImage_Click(object sender, EventArgs e) //blending image
        {
            List<Image<Bgr, byte>> listImages = Metode.GetImage(@"C:\Users\diana\OneDrive\Desktop\Laborator5", "*.png");

            List<Bitmap> listImagesReturn = Metode.BlendingImage(listImages);

            for (int i = 0; i < listImagesReturn.Count; i++)
            {
                pictureBox1.Image = listImagesReturn[i];
                await Task.Delay(25);

            }
        }

        

        private async void ReadAllFrames()
        {

            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                pictureBox7.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                return;
            }

            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
                Math.Min(StartROI.Y, e.Y),
                width,
                height);
            Refresh();
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBox2.Image == null || rect == Rectangle.Empty)
            { return; }

            var img = new Bitmap(pictureBox2.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();

            pictureBox1.Image = imgROI.ToBitmap();
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colorchange_Click(object sender, EventArgs e)// red color channel
        {
            pictureBox1.Image = Metode.Colorchannel(My_Image).AsBitmap();
        }

        


    }
}
