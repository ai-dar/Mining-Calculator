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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
            label15.Text = "0$";
            label16.Text = "0$";
            label17.Text = "0$";
            label18.Text = "0$";
            label19.Text = "0$";
            label20.Text = "0$";
            label21.Text = "0$";
            label22.Text = "0$";
            for (int i = 0; i <= 10; i++)
            {
                if (OZU.countozu[i] != 0)
                {
                    Calc.sumhour += OZU.dohodozu[i] * OZU.countozu[i];
                    Calc.rashodhour += OZU.kwozu[i] * Calc.rashour;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (HDD.counthdd[i] != 0)
                {
                    Calc.sumhour += HDD.dohodhdd[i] * HDD.counthdd[i];
                    Calc.rashodhour += HDD.kwhdd[i] * Calc.rashour;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (POWERUNIT.countpowerunit[i] != 0)
                {
                    Calc.sumhour += POWERUNIT.dohodpowerunit[i] * POWERUNIT.countpowerunit[i];
                    Calc.rashodhour += POWERUNIT.kwpowerunit[i] * Calc.rashour;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (PROCCESORR.countprocessor[i] != 0)
                {
                    Calc.sumhour += PROCCESORR.dohodprocessor[i] * PROCCESORR.countprocessor[i];
                    Calc.rashodhour += PROCCESORR.kwprocessor[i] * Calc.rashour;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (VIDEOCART.countvideocart[i] != 0)
                {
                    Calc.sumhour += VIDEOCART.dohodvideocart[i] * VIDEOCART.countvideocart[i];
                    Calc.rashodhour += VIDEOCART.kwvideocart[i] * Calc.rashour;
                }
            }
            label19.ForeColor = Color.Red;
            label20.ForeColor = Color.Red;
            label21.ForeColor = Color.Red;
            label22.ForeColor = Color.Red;
            label19.Text = $"{Calc.rashodhour}$";
            label20.Text = $"{24 * Calc.rashodhour}$";
            label21.Text = $"{30 * (24 * Calc.rashodhour)}$";
            label22.Text = $"{12 * (30 * (24 * Calc.rashodhour))}$";
            if (Calc.sumhour > Calc.rashodhour)
            {
                label15.ForeColor = Color.Green;
                label15.Text = $"+{Calc.sumhour - Calc.rashodhour }$";
                label17.ForeColor = Color.Green;
                label17.Text = $"+{24 * (Calc.sumhour - Calc.rashodhour)}$";
                label18.ForeColor = Color.Green;
                label18.Text = $"+{30 * (24 * (Calc.sumhour - Calc.rashodhour))}$";
                label16.ForeColor = Color.Green;
                label16.Text = $"+{12 * (30 * (24 * (Calc.sumhour - Calc.rashodhour)))}$";
            }
            else if (Calc.sumhour < Calc.rashodhour)
            {
                label15.ForeColor = Color.Red;
                label15.Text = $"-{Calc.rashodhour - Calc.sumhour}$";
                label17.ForeColor = Color.Red;
                label17.Text = $"-{24 * (Calc.sumhour - Calc.rashodhour) }$";
                label18.ForeColor = Color.Red;
                label18.Text = $"-{30 * (24 * (Calc.sumhour - Calc.rashodhour)) }$";
                label16.ForeColor = Color.Red;
                label16.Text = $"-{12 * (30 * (24 * (Calc.sumhour - Calc.rashodhour)))}$";
            }
            else
            {
                label15.ForeColor = Color.Gray;
                label15.Text = $"{Calc.rashodhour - Calc.sumhour}$";
                label17.ForeColor = Color.Gray;
                label17.Text = $"{24 * (Calc.sumhour - Calc.rashodhour) }$";
                label18.ForeColor = Color.Gray;
                label18.Text = $"{30 * (24 * (Calc.sumhour - Calc.rashodhour)) }$";
                label16.ForeColor = Color.Gray;
                label16.Text = $"{12 * (30 * (24 * (Calc.sumhour - Calc.rashodhour)))}$";
            }
            ClearAllCount();

        }

        void ClearAllCount()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (OZU.countozu[i] != 0)
                {
                    OZU.countozu[i] = 0;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (HDD.counthdd[i] != 0)
                {
                    HDD.counthdd[i] = 0;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (POWERUNIT.countpowerunit[i] != 0)
                {
                    POWERUNIT.countpowerunit[i] = 0;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (PROCCESORR.countprocessor[i] != 0)
                {
                    PROCCESORR.countprocessor[i] = 0;
                }
            }
            for (int i = 0; i <= 10; i++)
            {
                if (VIDEOCART.countvideocart[i] != 0)
                {
                    VIDEOCART.countvideocart[i] = 0;
                }
            }
            Calc.sumhour = 0;
            Calc.rashodhour = 0;
            for (int i = 0; i <= 50; i++)
            {
                Basket.ListB[i] = "";
            }
            Basket.PListB = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text = "0$";
            label16.Text = "0$";
            label17.Text = "0$";
            label18.Text = "0$";
            label19.Text = "0$";
            label20.Text = "0$";
            label21.Text = "0$";
            label22.Text = "0$";
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void Calculate_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Calculate_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
