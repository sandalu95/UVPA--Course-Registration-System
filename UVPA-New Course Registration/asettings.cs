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

namespace UVPA_New_Course_Registration
{
    public partial class asettings : Form
    {
        public asettings()
        {
            InitializeComponent();
        }
        public string uname { get; set; }
        public string pword { get; set; }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (pword == currentpwordtxt.Text && (newpwordtxt.Text == confirmpwordtxt.Text))
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query1 = "update account set Password = '"+newpwordtxt.Text+"' where UserName = '"+uname+"' ";
                MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                conn.CloseConnection();
            }
            else if (pword!=currentpwordtxt.Text)
            {
                MessageBox.Show("curreent password is wrong");
            }
            else
            {
                MessageBox.Show("new password is wrong");
            }
        }

        private void currentpwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
