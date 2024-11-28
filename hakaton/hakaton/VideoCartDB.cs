using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hakaton
{
    public partial class VideoCartDB : Form
    {
        public VideoCartDB()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add($"{VIDEOCART.typevideocart[i]} - {VIDEOCART.kwvideocart[i]} USD/kWH - {VIDEOCART.dohodvideocart[i]} $");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void VideoCartDB_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void VideoCartDB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
