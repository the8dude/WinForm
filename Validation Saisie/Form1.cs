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

namespace Validation_Saisie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                MessageBox.Show("Nom : " + textBox1.Text + "\n" + "Date : " + textBox2.Text + "\n" + dateTimePicker1.Text + "\n" + "Montant : " + textBox3.Text + "\n" + "Code Postal : " + textBox4.Text, "Validation effectuée");

                DialogResult dr = MessageBox.Show
                ("Fin de l’application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex re_nom = new Regex(@"^[a-zA-Z]{1,30}$");


            if (re_nom.IsMatch(textBox1.Text))
            {
                label7.Visible = true;
                label7.Text = "Nom OK";
                label7.ForeColor = Color.Green;
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Erreur";
                label7.ForeColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex re_date = new Regex(@"^[0-3][0-9]/[0-1][0-9]/[0-2][0-9][0-9][0-9]$");

            if (re_date.IsMatch(textBox2.Text) && Convert.ToDateTime(textBox2.Text) > DateTime.Now)
            {
                label6.Visible = true;
                label6.Text = "Date OK";
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.Visible = true;
                label6.Text = "Erreur";
                label6.ForeColor = Color.Red;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex re_prix = new Regex(@"^[0-9]+((.|,)[0-9]{2})?$");
            if (re_prix.IsMatch(textBox3.Text))
            {
                label8.Visible = true;
                label8.Text = "Montant OK";
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.Visible = true;
                label8.Text = "Erreur";
                label8.ForeColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Regex re_cp = new Regex(@"^[0-9][0-9][0-9][0-9][0-9]$");
            if (re_cp.IsMatch(textBox4.Text))
            {
                label9.Visible = true;
                label9.Text = "Code Postal OK";
                label9.ForeColor = Color.Green;

            }
            else
            {
                label9.Visible = true;
                label9.Text = "Erreur";
                label9.ForeColor = Color.Red;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
