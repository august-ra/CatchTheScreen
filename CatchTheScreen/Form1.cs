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
        public Bitmap image; // = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public Bitmap canvas;
        public PictureBox pictureBox;

        public float factor = 1f;

        public FishingForm()
        {
            InitializeComponent();

            timeoutComboBox.SelectedIndex = 3;

            MakeScreenshot();
        }

        public void MakeScreenshot(int timeout = 3000) {
            if (timeout != 0)
                System.Threading.Thread.Sleep(timeout);

            mainPanel.Controls.Clear();

            if (pictureBox != null) {
                pictureBox.Dispose();
                image.Dispose();
            }

            image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(image as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, image.Size);
            graphics.Dispose();

            FillForm();
        }

        public void FillForm()
        {
            pictureBox = new PictureBox();
            pictureBox.Image    = image;
            pictureBox.Width    = image.Width;
            pictureBox.Height   = image.Height;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);

            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(pictureBox);
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
            switch (scaleTrackBar.Value) {
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

            Size size = new Size((int) (image.Width * factor), (int) (image.Height * factor));

            canvas = new Bitmap(size.Width, size.Height);

            Graphics graphics = Graphics.FromImage(canvas);
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graphics.DrawImage(image, new Rectangle(new Point(0, 0), size), new Rectangle(new Point(0, 0), image.Size), GraphicsUnit.Pixel);
            graphics.Dispose();

            pictureBox.Image = canvas;

            canvas.Dispose();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Hide();

            int timeout;

            switch (timeoutComboBox.SelectedIndex) {
                case 0:
                    timeout = 0;
                    break;
                case 1:
                    timeout = 1000;
                    break;
                case 2:
                    timeout = 2000;
                    break;
                case 3:
                    timeout = 3000;
                    break;
                case 4:
                    timeout = 4000;
                    break;
                default:
                    timeout = 5000;
                    break;
            }

            MakeScreenshot(timeout);

            Show();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            mainPanel.Controls.Clear();

            if (pictureBox != null) {
                pictureBox.Dispose();
                image.Dispose();
            }

            image = new Bitmap(dialog.FileName);

            FillForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
                image.Save(dialog.FileName);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(image);
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsImage())
                return;

            mainPanel.Controls.Clear();

            if (pictureBox != null) {
                pictureBox.Dispose();
                image.Dispose();
            }

            image = new Bitmap(Clipboard.GetImage());

            FillForm();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);

            if (factor != 1) {
                point.X = (int) (e.X / factor);
                point.Y = (int) (e.Y / factor);
            }

            Color color = Color.FromName("Maroon");
            Pen   pen   = new Pen(color, 3f);

            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawLine(pen, point.X - 20, point.Y, point.X + 20, point.Y);
            //Color color2 = image.GetPixel(point.X, point.Y);
            //graphics.DrawLine(new Pen(color2, 4f), point.X - 40, point.Y + 5, point.X + 40, point.Y + 5);
            graphics.Dispose();

            pen.Dispose();

            pictureBox.Image = image;
        }
    }
}
