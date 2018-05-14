using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace UVPA_New_Course_Registration
{
    class DBConnect
    {
        public MySqlConnection connection;
        public bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection("server = localhost; user id = root; password=root; persistsecurityinfo = True; database = course_registration_system");
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Cannot connect to server");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Invalid username/Password");
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
