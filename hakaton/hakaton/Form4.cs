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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            comboBox1.Text = "Type Gadgets";
            comboBox2.Text = "Model";
            comboBox4.Text = "1";
            comboBox1.Items.Add("Processor");
            comboBox1.Items.Add("Videocart");
            comboBox1.Items.Add("RAM");
            comboBox1.Items.Add("HDD");
            comboBox1.Items.Add("Power Unit");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Processor")
            {
                comboBox2.Text = PROCCESORR.typeprocessor[0];
                label1.Text = PROCCESORR.kwprocessor[0].ToString();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                for (int i = 2; i <= 10; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
                comboBox2.Items.Add(PROCCESORR.typeprocessor[0]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[1]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[2]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[3]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[4]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[5]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[6]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[7]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[8]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[9]);
                comboBox2.Items.Add(PROCCESORR.typeprocessor[10]);
            }
            else if (comboBox1.Text == "RAM")
            {
                comboBox2.Text = OZU.typeozu[0];
                label1.Text = OZU.kwozu[0].ToString();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                for (int i = 2; i <= 10; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
                comboBox2.Items.Add(OZU.typeozu[0]);
                comboBox2.Items.Add(OZU.typeozu[1]);
                comboBox2.Items.Add(OZU.typeozu[2]);
                comboBox2.Items.Add(OZU.typeozu[3]);
                comboBox2.Items.Add(OZU.typeozu[4]);
                comboBox2.Items.Add(OZU.typeozu[5]);
                comboBox2.Items.Add(OZU.typeozu[6]);
                comboBox2.Items.Add(OZU.typeozu[7]);
                comboBox2.Items.Add(OZU.typeozu[8]);
                comboBox2.Items.Add(OZU.typeozu[9]);
                comboBox2.Items.Add(OZU.typeozu[10]);
            }
            else if (comboBox1.Text == "Videocart")
            {
                comboBox2.Text = VIDEOCART.typevideocart[0];
                label1.Text = VIDEOCART.kwvideocart[0].ToString();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                for (int i = 2; i <= 10; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
                comboBox2.Items.Add(VIDEOCART.typevideocart[0]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[1]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[2]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[3]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[4]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[5]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[6]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[7]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[8]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[9]);
                comboBox2.Items.Add(VIDEOCART.typevideocart[10]);
            }
            else if (comboBox1.Text == "HDD")
            {
                comboBox2.Text = HDD.typehdd[0];
                label1.Text = HDD.kwhdd[0].ToString();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                for (int i = 2; i <= 10; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
                comboBox2.Items.Add(HDD.typehdd[0]);
                comboBox2.Items.Add(HDD.typehdd[1]);
                comboBox2.Items.Add(HDD.typehdd[2]);
                comboBox2.Items.Add(HDD.typehdd[3]);
                comboBox2.Items.Add(HDD.typehdd[4]);
                comboBox2.Items.Add(HDD.typehdd[5]);
                comboBox2.Items.Add(HDD.typehdd[6]);
                comboBox2.Items.Add(HDD.typehdd[7]);
                comboBox2.Items.Add(HDD.typehdd[8]);
                comboBox2.Items.Add(HDD.typehdd[9]);
                comboBox2.Items.Add(HDD.typehdd[10]);
            }
            else if (comboBox1.Text == "Power Unit")
            {
                comboBox2.Text = POWERUNIT.typepowerunit[0];
                label1.Text = POWERUNIT.kwpowerunit[0].ToString();
                comboBox2.Items.Clear();
                comboBox4.Items.Clear();
                for (int i = 2; i <= 10; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
                comboBox2.Items.Add(POWERUNIT.typepowerunit[0]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[1]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[2]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[3]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[4]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[5]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[6]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[7]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[8]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[9]);
                comboBox2.Items.Add(POWERUNIT.typepowerunit[10]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "Model" && comboBox1.Text != "Type Gadget")
            {
                Basket.Model = comboBox2.Text;
                Basket.Amount = comboBox4.Text;
                if (comboBox1.Text == "Processor")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBox2.Text == PROCCESORR.typeprocessor[i])
                        {
                            PROCCESORR.countprocessor[i] += int.Parse(comboBox4.Text);
                        }
                    }
                }
                else if (comboBox1.Text == "RAM")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBox2.Text == OZU.typeozu[i])
                        {
                            OZU.countozu[i] += int.Parse(comboBox4.Text);
                        }
                    }
                }
                else if (comboBox1.Text == "Videocart")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBox2.Text == VIDEOCART.typevideocart[i])
                        {
                            VIDEOCART.countvideocart[i] += int.Parse(comboBox4.Text);
                        }
                    }
                }
                else if (comboBox1.Text == "HDD")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBox2.Text == HDD.typehdd[i])
                        {
                            HDD.counthdd[i] += int.Parse(comboBox4.Text);
                        }
                    }
                }
                else if (comboBox1.Text == "Power Unit")
                {
                    for (int i = 0; i < 11; i++)
                    {
                        if (comboBox2.Text == POWERUNIT.typepowerunit[i])
                        {
                            POWERUNIT.countpowerunit[i] += int.Parse(comboBox4.Text);
                        }
                    }
                }
                Form5 f5 = new Form5();
                f5.AddToListBox(comboBox2.Text, comboBox4.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Close();
            f5.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Processor")
            {
                for (int i = 0; i < 11; i++)
                {
                    if (comboBox2.Text == PROCCESORR.typeprocessor[i])
                    {
                        label1.Text = PROCCESORR.kwprocessor[i].ToString();
                    }
                }
            }
            else if (comboBox1.Text == "RAM")
            {
                for (int i = 0; i < 11; i++)
                {
                    if (comboBox2.Text == OZU.typeozu[i])
                    {
                        label1.Text = OZU.kwozu[i].ToString();
                    }
                }
            }
            else if (comboBox1.Text == "Videocart")
            {
                for (int i = 0; i < 11; i++)
                {
                    if (comboBox2.Text == VIDEOCART.typevideocart[i])
                    {
                        label1.Text = VIDEOCART.kwvideocart[i].ToString();
                    }
                }
            }
            else if (comboBox1.Text == "HDD")
            {
                for (int i = 0; i < 11; i++)
                {
                    if (comboBox2.Text == HDD.typehdd[i])
                    {
                        label1.Text = HDD.kwhdd[i].ToString();
                    }
                }
            }
            else if (comboBox1.Text == "Power Unit")
            {
                for (int i = 0; i < 11; i++)
                {
                    if (comboBox2.Text == POWERUNIT.typepowerunit[i])
                    {
                        label1.Text = POWERUNIT.kwpowerunit[i].ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate f6 = new Calculate();
            f6.Show();
            this.Close();
        }
        Point lastPoint;
        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
