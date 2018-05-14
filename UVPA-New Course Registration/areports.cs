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
    public partial class areports : Form
    {
        public areports()
        {
            InitializeComponent();
        }

        private void areports_Load(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            string Query = "SELECT * FROM student";
            conn.OpenConnection();
            MySqlCommand command = new MySqlCommand(Query, conn.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                stureportcombo.Items.Add(reader.GetString("StuNo"));
            }
            conn.CloseConnection();
        }
    }
}
