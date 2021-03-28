using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheScreen
{
    public partial class FishingForm : Form
    {
        public static Bitmap image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public Bitmap canvas;
        public PictureBox pictureBox;

        public FishingForm()
        {
            InitializeComponent();

            System.Threading.Thread.Sleep(3000);

            Graphics graphics = Graphics.FromImage(image as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, image.Size);

            pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Width = image.Width;
            pictureBox.Height = image.Height;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(pictureBox);

            scaleTrackBar.Value = 2;
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            int value = scaleTrackBar.Value - 1;

            if (value < 0)
                value = 0;

            scaleTrackBar.Value = value;
            scaleTrackBar_Scroll(sender, e);
        }

        private void incButton_Click(object sender, EventArgs e)
        {
            int value = scaleTrackBar.Value + 1;

            if (value > 9)
                value = 9;

            scaleTrackBar.Value = value;
            scaleTrackBar_Scroll(sender, e);
        }

        private void scaleTrackBar_Scroll(object sender, EventArgs e)
        {
            float factor = scaleTrackBar.Value + 1;

            switch (scaleTrackBar.Value)
            {
                case 0:
                    factor = .25f;
                    scaleLabel.Text = "25%";
                    break;
                case 1:
                    factor = .5f;
                    scaleLabel.Text = "50%";
                    break;
                case 2:
                    factor = 1f;
                    scaleLabel.Text = "100%";
                    break;
                case 3:
                    factor = 2f;
                    scaleLabel.Text = "200%";
                    break;
                case 4:
                    factor = 3f;
                    scaleLabel.Text = "300%";
                    break;
                case 5:
                    factor = 4f;
                    scaleLabel.Text = "400%";
                    break;
                case 6:
                    factor = 5f;
                    scaleLabel.Text = "500%";
                    break;
                case 7:
                    factor = 6f;
                    scaleLabel.Text = "600%";
                    break;
                case 8:
                    factor = 7f;
                    scaleLabel.Text = "700%";
                    break;
                default:
                    factor = 8f;
                    scaleLabel.Text = "800%";
                    break;
            }

            Size size = new Size((int)(image.Width * factor), (int)(image.Height * factor));

            canvas = new Bitmap(size.Width, size.Height);

            Graphics graphics = Graphics.FromImage(canvas);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graphics.DrawImage(image, new Rectangle(new Point(0, 0), size), new Rectangle(new Point(0, 0), image.Size), GraphicsUnit.Pixel);
            graphics.Dispose();

            pictureBox.Image = canvas;
        }
    }
}
