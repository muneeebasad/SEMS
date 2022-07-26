using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SEMS
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Muneeb\source\repos\SEMS\SEMS\usersDB.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM loginTB WHERE Username='" + txtusername.Text + "' AND Password='" + txtpass.Text + "'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                homePage home = new homePage();
                home.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");

            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Are You Sure To Exit Programme ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
