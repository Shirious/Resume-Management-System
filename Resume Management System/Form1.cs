using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t_welcome_Tick(object sender, EventArgs e)
        {
            pgbr_welcome.Minimum = 0;
            pgbr_welcome.Maximum = 450;
            pgbr_welcome.PerformStep();
            if (pgbr_welcome.Value == pgbr_welcome.Maximum)
            {
                t_welcome.Stop();
                Login_Screen lgn = new Login_Screen();
                this.Visible = false;
                lgn.Show();
            }
        }
    }
}
