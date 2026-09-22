using firstapp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            number += 1;
            label1.Text = number.ToString();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Resources._2;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Image = Resources._1;
        }
    }
}
