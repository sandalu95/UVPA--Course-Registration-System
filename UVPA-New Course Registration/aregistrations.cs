using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data;

namespace UVPA_New_Course_Registration
{
    public partial class aregistrations : Form
    {
        public aregistrations()
        {
            InitializeComponent();
        }

        public void populateDGV()
        {
            //populate the datagridview
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            string selectQuery = "SELECT*FROM account";

            //ListSortDirection direction;
            //dataGridView_accou.Sort(dataGridView_accou.Columns["password"], direction);
            //    dataGridView_accou.Sort(dataGridView_accou.Columns[1], ListSortDirection.Ascending);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn.connection);
            adapter.Fill(table);
            // dataGridView_accou.Sort(dataGridView_accou.Columns[1], ListSortDirection.Ascending);
            dataGridView_accou.DataSource = table;
            conn.CloseConnection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            string query1 = "INSERT INTO account(UserName,Password,PasswordHint) VALUES ('" + txtUsername.Text + "','" + txtPasswotd.Text + "','" + txtPasswotd.Text + "')";
            if (conn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save data");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
                conn.CloseConnection();
            }
            populateDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            string deleteQuery = "delete from account where UserName='" + this.txtUsername.Text + "'";
            DialogResult result = MessageBox.Show("Are you sure to delete record?", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (conn.OpenConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn.connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Not Deleted");
                    }
                    conn.CloseConnection();
                }
                else { }
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
            populateDGV();

        }

        private void aregistrations_Load(object sender, EventArgs e)
        {
            populateDGV();
            DBConnect conn = new DBConnect();
            string Query = "SELECT * FROM student";
            conn.OpenConnection();
            MySqlCommand command = new MySqlCommand(Query, conn.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                studentcombo.Items.Add(reader.GetString("StuNo"));
            }
            conn.CloseConnection();
        }

        private void dataGridView_accou_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dataGridView_accou.CurrentRow.Cells[0].Value.ToString();
            txtPasswotd.Text = dataGridView_accou.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            string updateQuery = "UPDATE account SET UserName='" + this.txtUsername.Text + "',Password='" + this.txtPasswotd.Text + "',PasswordHint='" + this.txtPasswotd.Text + "' WHERE UserName='" + this.txtUsername.Text + "';";
            if (conn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn.connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
                conn.CloseConnection();
            }
            populateDGV();
        }

        ustuinfo stuinfo;
        private void viewbutton_Click(object sender, EventArgs e)
        {
            stuinfo = new ustuinfo();
            stuinfo.StartPosition = FormStartPosition.Manual;
            stuinfo.Location = new Point(345, 38);
            stuinfo.Disabled();
            stuinfo.ButtonDisable();  
            stuinfo.Show();
            stuinfo.TextBoxValue = this.GetStudentNo();
        }

        private void Stuinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            stuinfo = null;
            //throw new NotImplementedException();
        }

        string sid;
        public string GetStudentNo()
        {
            sid = studentcombo.Text;
            return sid;
        }

        private void studentcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
