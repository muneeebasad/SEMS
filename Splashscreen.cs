using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMS
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            metroProgressBar1.Value = startpoint;
            if (metroProgressBar1.Value == 100)
            {
                metroProgressBar1.Value = 0;
                timer1.Stop();
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();

            }

        }
        private void Splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
