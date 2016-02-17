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
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 189;
            hScrollBar1.Minimum = 1;

            //LABEL 5

            label5.Text = hScrollBar1.Value.ToString();
            
            if (listBox1.SelectedIndex == 1)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 2) * 2;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 20;
                hScrollBar1.Minimum = 0;
            }
            if (listBox1.SelectedIndex == 2)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 3) * 3;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 30;
                hScrollBar1.Minimum = 0;
            }
            if (listBox1.SelectedIndex == 3)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 6) * 6;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 60;
                hScrollBar1.Minimum = 0;
            }
            if (listBox1.SelectedIndex == 4)
            {
                hScrollBar1.Value = (hScrollBar1.Value / 12) * 12;
                label5.Text = hScrollBar1.Value.ToString();
                hScrollBar1.LargeChange = 120;
                hScrollBar1.Minimum = 0;
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
            textBox1.Focus();

            Regex re_nom = new Regex(@"^[a-zA-Z]{1,30}$");


            if (re_nom.IsMatch(textBox1.Text))
            {
                label10.Visible = true;
                label10.Text = "Nom OK";
                label10.ForeColor = Color.Green;
            }
            else
            {
                label10.Visible = true;
                label10.Text = "Erreur";
                label10.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex re_capital = new Regex(@"^[0-9]{1,10}$");
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
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
