using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sleep
{
    public partial class Timer : Form
    {
        int time;
        string test;
        public Timer()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Desligar_Click(object sender, EventArgs e)
        {
            time = int.Parse(txt_Time.Text);
            time = time * 60;
            test = "-s -t " + Convert.ToString(time);
            Process.Start("shutdown", test);
            this.Close();
        }
    }
}
