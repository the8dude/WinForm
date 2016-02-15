using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_4___Défilement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;

            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = 264;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;

            hScrollBar2.Minimum = 0;
            hScrollBar2.Maximum = 264;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;

            hScrollBar3.Minimum = 0;
            hScrollBar3.Maximum = 264;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           hScrollBar1.Value = Convert.ToInt32(numericUpDown1.Value);
           label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           hScrollBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown1.Text = hScrollBar1.Value.ToString();
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown2.Text = hScrollBar2.Value.ToString();
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            numericUpDown3.Text = hScrollBar3.Value.ToString();
            label7.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
