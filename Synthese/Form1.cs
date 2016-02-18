using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Synthese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Select();
            listBox1.SelectedIndex = 0;
            textBox1.Select();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label9.Text = "0 €";

            //LABEL 5


            if (listBox1.SelectedIndex == 0)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 1) * 1;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 10;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 189;
            }
            if (listBox1.SelectedIndex == 1)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 2) * 2;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 20;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 199;

            }
            if (listBox1.SelectedIndex == 2)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 3) * 3;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 30;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 209;
            }
            if (listBox1.SelectedIndex == 3)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 6) * 6;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 60;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 239;
            }
            if (listBox1.SelectedIndex == 4)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 12) * 12;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 120;
                hScrollBar1.Minimum = 0;
                hScrollBar1.Maximum = 299;
            }
            //LABEL 8
            if (listBox1.SelectedIndex == 0)
            {
                label8.Text = hScrollBar1.Value.ToString();
            }
            if (listBox1.SelectedIndex == 1)
            {
                label8.Text = (hScrollBar1.Value / 2).ToString();
            }
            if (listBox1.SelectedIndex == 2)
            {
                label8.Text = (hScrollBar1.Value / 3).ToString();
            }
            if (listBox1.SelectedIndex == 3)
            {
                label8.Text = (hScrollBar1.Value / 6).ToString();
            }
            if (listBox1.SelectedIndex == 4)
            {
                label8.Text = (hScrollBar1.Value / 12).ToString();
            }




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex re_nom = new Regex(@"^[a-zA-Z]{1,30}$");


            if (re_nom.IsMatch(textBox1.Text))
            {
                label10.Visible = true;
                label10.Text = "Nom OK";
                label10.ForeColor = Color.Green;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    label10.Visible = false;
                }
                else
                {
                    label10.Visible = true;
                    label10.Text = "Erreur";
                    label10.ForeColor = Color.Red;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "0 €";

            Regex re_capital = new Regex(@"^[0-9]{1,10}$");

            if (textBox2.Text == "")
            {
                label11.Visible = false;
            }

            else

            if (re_capital.IsMatch(textBox2.Text))
            {
                label11.Visible = true;
                label11.Text = "Capital OK";
                label11.ForeColor = Color.Green;
            }
            else
            {
                label11.Visible = true;
                label11.Text = "Uniquement \n des chiffres";
                label11.ForeColor = Color.Red;
            }

            if (textBox2.Text.Length > 10)
            {
                label11.Visible = true;
                label11.Text = "10 chiffres \n maximum";
                label11.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Veuillez saisir un montant dans la partie \"Capital\" !!!!");
            }

            //LABEL 9 FORMULE

            //List Box Index 0
            if (listBox1.SelectedIndex == 0)
            {
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(label8.Text);
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;


                if (radioButton1.Checked == true)
                {
                    label9.Text = (((k * (t7 / 12)) / (1 - (Math.Pow((1 + (t7 / 12)), -n))))).ToString() + " €";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = (((k * (t8 / 12)) / (1 - (Math.Pow((1 + (t8 / 12)), -n))))).ToString() + " €";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = (((k * (t9 / 12)) / (1 - (Math.Pow((1 + (t9 / 12)), -n))))).ToString() + " €";
                }
            }

            //List Box Index 1
            if (listBox1.SelectedIndex == 1)
            {
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(label8.Text);
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;


                if (radioButton1.Checked == true)
                {
                    label9.Text = (((k * (t7 / 6)) / (1 - (Math.Pow((1 + (t7 / 6)), -n))))).ToString() + " €";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = (((k * (t8 / 6)) / (1 - (Math.Pow((1 + (t8 / 6)), -n))))).ToString() + " €";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = (((k * (t9 / 6)) / (1 - (Math.Pow((1 + (t9 / 6)), -n))))).ToString() + " €";
                }
            }

            //List Box Index 2
            if (listBox1.SelectedIndex == 2)
            {
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(label8.Text);
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;


                if (radioButton1.Checked == true)
                {
                    label9.Text = (((k * (t7 / 3)) / (1 - (Math.Pow((1 + (t7 / 3)), -n))))).ToString() + " €";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = (((k * (t8 / 4)) / (1 - (Math.Pow((1 + (t8 / 4)), -n))))).ToString() + " €";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = (((k * (t9 / 3)) / (1 - (Math.Pow((1 + (t9 / 3)), -n))))).ToString() + " €";
                }
            }

            //List Box Index 3
            if (listBox1.SelectedIndex == 3)
            {
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(label8.Text);
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;


                if (radioButton1.Checked == true)
                {
                    label9.Text = (((k * (t7 / 2)) / (1 - (Math.Pow((1 + (t7 / 2)), -n))))).ToString() + " €";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = (((k * (t8 / 2)) / (1 - (Math.Pow((1 + (t8 / 2)), -n))))).ToString() + " €";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = (((k * (t9 / 2)) / (1 - (Math.Pow((1 + (t9 / 2)), -n))))).ToString() + " €";
                }
            }

            //List Box Index 4
            if (listBox1.SelectedIndex == 4)
            {
                double k = Convert.ToDouble(textBox2.Text);
                double n = Convert.ToDouble(label8.Text);
                double t7 = 0.07;
                double t8 = 0.08;
                double t9 = 0.09;


                if (radioButton1.Checked == true)
                {
                    label9.Text = (((k * t7) / (1 - (Math.Pow((1 + t7), -n))))).ToString() + " €";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = (((k * t8) / (1 - (Math.Pow((1 + t8), -n))))).ToString() + " €";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = (((k * t9) / (1 - (Math.Pow((1 + t9), -n))))).ToString() + " €";
                }
            }
        }


        //INUTILE//

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = "0 €";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "0 €";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "0 €";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = "0 €";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
