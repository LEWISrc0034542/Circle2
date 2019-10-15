using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius, circumference, area;
            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect Input.");
                radius = 0.0;
            }

            circumference = 2.0 * Math.PI * radius;
            label1.Text = "Circumference = " + circumference;

            area = Math.PI * radius * radius;
            label2.Text = "Area = " + area;
        }
    }
}
