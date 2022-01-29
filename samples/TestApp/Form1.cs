using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string x = "";


            x += RuntimeInformation.FrameworkDescription + " " + RuntimeInformation.OSDescription + "(.NET version " + Environment.Version + ")";
            MessageBox.Show(this, x, "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}