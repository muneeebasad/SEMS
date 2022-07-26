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
    public partial class studentForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Muneeb\source\repos\SEMS\SEMS\usersDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public studentForm() => InitializeComponent();

        void GetStudentData()
        {
            cmd = new SqlCommand("SELECT * FROM Students", sqlcon);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            sqlcon.Close();
            sdataGridView.DataSource = dt;
        }
        private void studentForm_Load(object sender, EventArgs e)
        {
            GetStudentData();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage home = new homePage();
            home.Show();
        }
        

        private void sdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRollno.Text = sdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtSname.Text = sdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtSD.Text = sdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtSContact.Text = sdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtSEmail.Text = sdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            sportscombobox.Text = sdataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            txtRollno.Clear();
            txtSname.Clear();
            txtSD.Clear();
            txtSContact.Clear();
            txtSEmail.Clear();
            sportscombobox.SelectedIndex = -1;
            txtRollno.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Students VALUES ('" + txtRollno.Text + " ','" + txtSname.Text + " ','" + txtSD.Text + " ','" + txtSContact.Text + " ','" + txtSEmail.Text + " ','" + sportscombobox.Text + " ')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show("Succesfully Saved......!");
            GetStudentData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Students WHERE (Roll_no = '" + txtRollno.Text + " ')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show("Succesfully Deleted......!");
            GetStudentData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Students SET Roll_no ='" + txtRollno.Text + "', Student_Name = '" + txtSname.Text + "', Department = '" + txtSD.Text + "', Contact_no ='" + txtSContact.Text + "', Email = '" + txtSEmail.Text + "', Sports = '" + sportscombobox.Text + "' WHERE (Roll_no = '" + txtRollno.Text + "')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show(" Updated Succesfully ......!");
            GetStudentData();
        }

        private void sportscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Students Where (Sports like '%" + sportscombobox.Text + "%')", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            sdataGridView.DataSource = dt;
        }
    }
}
