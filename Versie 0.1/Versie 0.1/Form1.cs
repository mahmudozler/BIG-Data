using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versie_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string wijk = textBox1.Text;
            textBox1.Clear();
            string A1 = "delfshaven";
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            if (wijk == A1)
            {
                pictureBox1.Load(currentpath + "/A1.png");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Resetmap_Click(object sender, EventArgs e)
        {
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            pictureBox1.Load(currentpath + "/MAP.png");
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            double scale = 150.0 / 100.0;
            Bitmap img;
            img = new Bitmap(pictureBox1.Image,
                Convert.ToInt32(pictureBox1.Width * scale), 
                Convert.ToInt32(pictureBox1.Height * scale));
            pictureBox1.Image = img;
        }

        private void Zoomout_Click(object sender, EventArgs e)
        {
            double scale = 100.0 / 150.0;
            Bitmap img;
            img = new Bitmap(pictureBox1.Image,
                Convert.ToInt32(pictureBox1.Width * scale), Convert.ToInt32(pictureBox1.Height * scale));
            pictureBox1.Image = img;
        }

        private void Security_Click(object sender, EventArgs e)
        {
            Bitmap DrawArea;
            DrawArea = new Bitmap(pictureBox1.Image);
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Brushes.Black,2);
            // SolidBrush redBrush = new SolidBrush(Color.Red);
            Color newColor = Color.FromArgb(100, Color.Red);

            // g.DrawEllipse(mypen, 200, 200, 200, 200);
            g.FillEllipse(new SolidBrush(newColor), 200, 200, 200, 200);
            pictureBox1.Image = DrawArea;
        }
    }
}
