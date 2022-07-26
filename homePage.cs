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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void manageTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachersForm teachersForm = new teachersForm();
            teachersForm.Show();
            this.Hide();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentForm studentForm = new studentForm();
            studentForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm results = new ResultsForm();
            results.Show();
            this.Close();
        }
    }
}
