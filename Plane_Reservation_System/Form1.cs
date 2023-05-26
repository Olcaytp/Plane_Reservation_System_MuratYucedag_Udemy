using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plane_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + "-" + comboBox2.Text + " and Date & Time is: " + dateTimePicker1.Text + "-" + maskedTextBox2.Text);
            listBox2.Items.Add( maskedTextBox3.Text + " - " + maskedTextBox4.Text);
            listBox3.Items.Add(maskedTextBox4.Text);
        } 
    }
}
