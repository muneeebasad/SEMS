using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace SEMS
{
    public partial class teachersForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Muneeb\source\repos\SEMS\SEMS\usersDB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public teachersForm() => InitializeComponent();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void GetTeachersRecord()
        {
            cmd = new SqlCommand("SELECT * FROM Teachers", sqlcon);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            sqlcon.Close();
            tdataGridView.DataSource = dt;
        }

        private void teachersForm_Load(object sender, EventArgs e)
        {

            GetTeachersRecord();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Teachers SET Teacher_Id ='" + txtTID.Text + "', Teacher_Name = '" + txtTname.Text + "', Teacher_Department = '" + txtTD.Text + "', Contact_no ='" + txtContact.Text + "', Email = '" + txtEmail.Text + "', Sports = '" + sportscombobox.Text + "' WHERE (Teacher_Id = '" + txtTID.Text + "')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show(" Updated Succesfully ......!");
            GetTeachersRecord();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            txtTID.Clear();
            txtTD.Clear();
            txtTname.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            sportscombobox.SelectedIndex = -1;
            txtTID.Focus();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Teachers VALUES ('" + txtTID.Text + " ','" + txtTname.Text + " ','" + txtTD.Text + " ','" + txtContact.Text + " ','" + txtEmail.Text + " ','" + sportscombobox.Text + " ')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show("Succesfully Saved......!");
            GetTeachersRecord();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            homePage home = new homePage();
            home.Show();
        }

        private void tdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTID.Text = tdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtTname.Text = tdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtTD.Text = tdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = tdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = tdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            sportscombobox.Text = tdataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Teachers WHERE (Teacher_Id = '" + txtTID.Text + " ')", sqlcon);
            cmd.ExecuteNonQuery();



            sqlcon.Close();
            MessageBox.Show("Succesfully Deleted......!");
            GetTeachersRecord();
        }

        private void sportscombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Teachers Where (Sports like '%" + sportscombobox.Text + "%')", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            tdataGridView.DataSource = dt;
        }
    }
}