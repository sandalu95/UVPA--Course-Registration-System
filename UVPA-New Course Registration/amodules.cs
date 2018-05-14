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
    public partial class amodules : Form
    {
        public amodules()
        {
            InitializeComponent();
        }

        string ctype;
        string cdept;
        string cyear;
        string csem;
        int cid;
        int ccredit;

        private void addconversions()
        {
            cid = Convert.ToInt32(cidtxt.Text);
            ccredit = Convert.ToInt32(ccreditstxt.Text);
            if (ctypetxt.Text == "Core")
            {
                ctype = "C";
            }
            else if (ctypetxt.Text == "Elective")
            {
                ctype = "E";
            }
            else
            {
                ctype = "A";
            }
            if (cdepttxt.Text == "Kandyan Dance")
            {
                cdept = "DKAN 01";
            }
            else if (cdepttxt.Text == "Low - Country Dance")
            {
                cdept = "DKAN 02";
            }
            else if (cdepttxt.Text == "Sabaragamuwa Dance")
            {
                cdept = "DKAN 03";
            }
            else if (cdepttxt.Text == "Indian and Asian Dance")
            {
                cdept = "DKAN 04";
            }
            else if (cdepttxt.Text == "Percussion Music")
            {
                cdept = "DKAN 05";
            }
            else if (cdepttxt.Text == "History and Theory of Dance and Drama")
            {
                cdept = "DKAN 06";
            }
            else
            {
                cdept = "DKAN 07";
            }
            if (cyeartxt.Text == "One")
            {
                cyear = "1";
            }
            else if (cyeartxt.Text == "Two")
            {
                cyear = "2";
            }
            else if (cyeartxt.Text == "Three")
            {
                cyear = "3";
            }
            else
            {
                cyear = "4";
            }
            if (csemtxt.Text == "Semester 1")
            {
                csem = "1";
            }
            else
            {
                csem = "2";
            }
        }
        private void caddbtn_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            this.addconversions();
            string query1 = "INSERT INTO subject(SubjectId,SubCode,SubName,SubType,Subcredit,Sem,YearId,AcYear,DeptNo) VALUES('"+cid + "','" +ccodetxt.Text + "','" +ctitletxt.Text + "','" +ctype + "','" +ccreditstxt.Text + "','" +csem + "','" +cyear + "','" +cacayeartxt.Text + "','" +cdept+"')";
            if (conn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                cmd.ExecuteNonQuery();
                conn.CloseConnection();
            }
            MessageBox.Show("Course is Added");
            clearbtn.PerformClick();
        }

        private void ceditbtn_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            this.addconversions();
            string updateQuery = "UPDATE subject SET SubjectId='" + this.cid + "',SubCode='" + this.ccodetxt.Text + "',SubName='" + this.ctitletxt.Text + "',SubType='" + this.ctype+ "',SubCredit='" + this.ccredit + "',Sem='" + this.csem + "',YearId='" + this.cyear + "',AcYear='" + this.cacayeartxt.Text + "',DeptNo='" + this.cdept + "' WHERE SubjectId='" + this.cid + "';";
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
            clearbtn.PerformClick();
        }

        private void cdeletebtn_Click(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            string deleteQuery = "delete from subject where SubjectId='"+cidtxt.Text+"'";
            DialogResult result = MessageBox.Show("Are you sure to delete record?", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (conn.OpenConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(deleteQuery, conn.connection);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Course is Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Course is not Deleted");
                    }
                    conn.CloseConnection();
                }
                else { }
            }
            else
            {
                MessageBox.Show("Course is not deleted");
            }
            clearbtn.PerformClick();
        }

        private void cidtxt_TextChanged(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            string query1 = "SELECT * FROM subject where SubjectId='" + cidtxt.Text + "'";
            if (conn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                MySqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    ccodetxt.Text = datareader.GetString(1);
                    ctitletxt.Text = datareader.GetString(2);
                    if (datareader.GetString(3) == "C")
                    {
                        ctypetxt.Text = "Core";
                    }
                    else if(datareader.GetString(3) == "E")
                    {
                        ctypetxt.Text = "Elective";
                    }
                    else
                    {
                        ctypetxt.Text = "Auxilary";
                    }
                 
                    ccreditstxt.Text = Convert.ToString(datareader.GetInt32(4));
                    if (datareader.GetString(5) == "1")
                    {
                        csemtxt.Text = "Semester 1";
                    }
                    else
                    {
                        csemtxt.Text = "Semester 2";
                    }
                    if (datareader.GetString(6) == "1")
                    {
                        cyeartxt.Text = "One";
                    }
                    else if (datareader.GetString(6) == "2")
                    {
                        cyeartxt.Text = "Two";
                    }
                    else if (datareader.GetString(6) == "3")
                    {
                        cyeartxt.Text = "Three";
                    }
                    else
                    {
                        cyeartxt.Text = "Four";
                    }
                    cacayeartxt.Text = datareader.GetString(7);
                    if (datareader.GetString(8) == "DKAN 01")
                    {
                        cdepttxt.Text = "Kandyan Dance";
                    }
                    else if (datareader.GetString(8) == "DKAN 02")
                    {
                        cdepttxt.Text = "Low-Country Dance";
                    }
                    else if (datareader.GetString(8) == "DKAN 03")
                    {
                        cdepttxt.Text = "Sabaragamuwa Dance";
                    }
                    else if (datareader.GetString(8) == "DKAN 04")
                    {
                        cdepttxt.Text = "Indian and Asian Dance";
                    }
                    else if (datareader.GetString(8) == "DKAN 05")
                    {
                        cdepttxt.Text = "Percussion Music";
                    }
                    else if (datareader.GetString(8) == "DKAN 06")
                    {
                        cdepttxt.Text = "History and Theory of Dance and Drama";
                    }
                    else
                    {
                        cdepttxt.Text = "Theatre, Ballet and Modern Dance";
                    }
                }
                datareader.Close();
                conn.CloseConnection();
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            cidtxt.Text = "";
            ccodetxt.Text = "";
            ctitletxt.Text = "";
            ctypetxt.Text = "";
            ccreditstxt.Text = "";
            csemtxt.Text = "";
            cyeartxt.Text = "";
            cacayeartxt.Text = "";
            cdepttxt.Text = "";
        }

       
    }
}






