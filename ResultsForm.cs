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
    public partial class ResultsForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Muneeb\source\repos\SEMS\SEMS\usersDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ResultsForm()
        {
            InitializeComponent();
        }

        void GetResults()
        {
            cmd = new SqlCommand("SELECT * FROM ResultTB", sqlcon);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            sqlcon.Close();
            rdataGridView.DataSource = dt;
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            GetResults();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage home = new homePage();
            home.Show();
        }

     

        private void rdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sportscombobox.Text = rdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txt1P.Text = rdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txt2P.Text = rdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txt3P.Text = rdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE ResultTB SET Sports_Name ='" + sportscombobox.Text + "', First_Position = '" + txt1P.Text + "', Second_Position = '" + txt2P.Text + "', Third_Position ='" + txt3P.Text + "' WHERE (Sports_Name = '" + sportscombobox.Text + "')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show(" Updated Succesfully ......!");
            GetResults();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            sportscombobox.SelectedIndex = -1;
            txt1P.Clear();
            txt2P.Clear();
            txt3P.Clear();
        }

        private void sportscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from ResultTB Where (Sports_Name like '%" + sportscombobox.Text + "%')", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            rdataGridView.DataSource = dt;
        }
    }
}
