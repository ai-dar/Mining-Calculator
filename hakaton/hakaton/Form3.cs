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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.Text = "Processor";
            comboBox1.Items.Add("Processor");
            comboBox1.Items.Add("Videocart");
            comboBox1.Items.Add("RAM");
            comboBox1.Items.Add("HDD");
            comboBox1.Items.Add("Power Unit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Processor")
            {
                ProccesorDBcs PrDB = new ProccesorDBcs();
                PrDB.Show();
                this.Close();
            }
            else if (comboBox1.Text == "RAM")
            {
                RAMDB PrDB = new RAMDB();
                PrDB.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Videocart")
            {
                VideoCartDB PrDB = new VideoCartDB();
                PrDB.Show();
                this.Close();
            }
            else if (comboBox1.Text == "HDD")
            {
                HDDDB PrDB = new HDDDB();
                PrDB.Show();
                this.Close();
            }
            else if (comboBox1.Text == "Power Unit")
            {
                PowerUnitDB PrDB = new PowerUnitDB();
                PrDB.Show();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
