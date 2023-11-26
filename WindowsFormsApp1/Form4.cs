using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Bitmap myBitmap;
        Graphics g;

        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            myBitmap = new Bitmap(640, 480);
            g = Graphics.FromImage(myBitmap); //get the graphics contact so that we can draw on the bitmap

            Pen p = new Pen(Color.Red, 2); //red pen 2 pixels wide
            g.DrawLine(p, 0, 0, 640, 480);

            Graphics windowG = e.Graphics;
            windowG.DrawImageUnscaled(myBitmap, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            myBitmap.Save("d:\\image1.jpg", ImageFormat.Jpeg);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("d:\\image1.jpg");
        }
    }
}
