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
    public partial class PowerUnitDB : Form
    {
        public PowerUnitDB()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add($"{POWERUNIT.typepowerunit[i]} - {POWERUNIT.kwpowerunit[i]} USD/kWH - {POWERUNIT.dohodpowerunit[i]} $");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
        Point lastPoint;
        private void PowerUnitDB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PowerUnitDB_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
