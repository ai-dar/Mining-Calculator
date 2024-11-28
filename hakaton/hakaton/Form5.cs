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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            if (Basket.w == true)
            {
                for (int i = 0; i <= 50; i++)
                {
                    if (Basket.ListB[i] != "")
                    {
                        listBox1.Items.Add(Basket.ListB[i]);
                    }
                }
            }
        }
        public void AddToListBox(string a, string b)
        {
            Basket.ListB[Basket.PListB] = $"{a} - {b}";
            for (int i = 0; i <= 50; i++)
            {
                if (Basket.ListB[i] != "")
                {
                    listBox1.Items.Add(Basket.ListB[i]);
                }
            }
            Basket.PListB += 1;
            Basket.w = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Close();
            f4.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
