using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_3___ListBox_et_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BUTTON 1&2
            if (comboBox1.Text != "")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //BUTTON 3
            if (listBox1.Text != "")
            {
                button3.Enabled = true;
            }
            
            //BUTTON 4
            if (listBox1.SelectedItem != null)
            {
                button4.Enabled = true;
            }
           
            //BUTTON 5
            if (listBox1.SelectedIndex == 0 || listBox1.SelectedItem == null)
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
            //BUTTON 6
            if (listBox1.SelectedIndex == 0 || listBox1.SelectedItem == null)
            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                listBox1.Items.Add(comboBox1.Items[i]);
            }
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            if (comboBox1.Text == "")
                button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            if (comboBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Focus();


            if (listBox1.SelectedItem == null)
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i]);
            }
            listBox1.Items.Clear();

            if (listBox1.Text == "")
            {
                button3.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    













































    private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void button4_EnabledChanged(object sender, EventArgs e)
        {



        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {

        }
    }

}
