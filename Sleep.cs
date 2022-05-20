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
    public partial class Sleep : Form
    {
        public Sleep()
        {
            InitializeComponent();
        }

        private void Sleep_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Timer j2 = new Timer();
            j2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-s -t 0"); 
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/r");
        }
    }
}
