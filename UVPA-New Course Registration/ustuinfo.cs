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
    public partial class ustuinfo : Form
    {
        public ustuinfo()
        {
            InitializeComponent();
        }


        private void ustuinfo_Load(object sender, EventArgs e)
        {
            year1deptpanel.Visible = false;
            deptgroup.Visible = false;
            
        }
        public string TextBoxValue
        {
            get { return stunotxt.Text; }
            set { stunotxt.Text = value; }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void btnyr1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnyr1.Checked)
            {
                year1deptpanel.Visible = true;
            }
            else
            {
                year1deptpanel.Visible = false;
            }
        }

        private void btnyr2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnyr2.Checked)
            {
                deptgroup.Visible = true;
            }
            else
            {
                deptgroup.Visible = false;
            }
        }

        private void btnyr3_CheckedChanged(object sender, EventArgs e)
        {
            if (btnyr3.Checked)
            {
                deptgroup.Visible = true;
            }
            else
            {
                deptgroup.Visible = false;
            }
        }

        private void btnyr4_CheckedChanged(object sender, EventArgs e)
        {
            if (btnyr4.Checked)
            {
                deptgroup.Visible = true;
            }
            else
            {
                deptgroup.Visible = false;
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            bbackbtn.Visible = false;
            stuinfopanel2.Visible = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            stunotxt.Text = "";
            fullnametxt.Text = "";
            lnametxt.Text = "";
            initialstxt.Text = "";
            addresstxt.Text = "";
            mobiletxt.Text = "";
            NIDtxt.Text = "";
            maleradiobtn.Checked = false;
            femaleradiobtn.Checked = false;
            intyeartxt.Text = "";
            Batchtxt.Text = "";
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string sex;
            DialogResult result = MessageBox.Show("Are You Sure You Want To Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                if (femaleradiobtn.Checked)
                {
                    sex = "F";
                }
                else
                {
                    sex = "M";
                }
                string query1 = "INSERT INTO student(StuNo,FullName,LName,Initials,Address,ContactNo,Sex,Batch,Degree,SpSubject,NID,DeptNo,UserName,IntakeYear) VALUES('" + stunotxt.Text + "','" + fullnametxt.Text + "','" + lnametxt.Text + "','" + initialstxt.Text + "','" + addresstxt.Text + "','" + mobiletxt.Text + "','" + sex + "','"+Batchtxt.Text+"','S','Kandyan Dance','"+NIDtxt.Text+"','DKAN 01','"+stunotxt.Text+"','"+intyeartxt.Text+"')";
                if (conn.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                    cmd.ExecuteNonQuery();
                    conn.CloseConnection();
                }
                    this.Close();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            stuinfopanel2.Visible = false;
        }


        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            uregistration reg = new uregistration();
            reg.Show();
            reg.StartPosition = FormStartPosition.Manual;
            reg.Location = new Point(345, 38);
        }
        

        private void stunotxt_TextChanged(object sender, EventArgs e)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            string query1 = "SELECT * FROM student where StuNo='" + stunotxt.Text + "'";
            if (conn.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query1, conn.connection);
                MySqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    fullnametxt.Text = datareader.GetString(1);
                    lnametxt.Text = datareader.GetString(2);
                    initialstxt.Text = datareader.GetString(3);
                    addresstxt.Text = datareader.GetString(4);
                    mobiletxt.Text = datareader.GetString(5);
                    NIDtxt.Text = datareader.GetString(10);
                    intyeartxt.Text = datareader.GetString(13);
                    Batchtxt.Text = datareader.GetString(7);
                    string sex= datareader.GetString(6);
                    if (sex == "M")
                    {
                        maleradiobtn.Checked = true;
                    }
                    else
                    {
                        femaleradiobtn.Checked = true;
                    }
                }
                datareader.Close();
                conn.CloseConnection();
            }
        }

        private void stunotxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fullnametxt.Focus();
            }
        }

        public void Disabled()
        {
            groupBox1.Hide();
            groupBox2.Hide();
            year1deptpanel.Hide();
            stuinfopanel2.Show();
            nextbtn.Hide();

        }

        public void ButtonDisable()
        {
            backbtn.Enabled = false;           
            clearbtn.Enabled = false;
            savebtn.Enabled = false;
            regbtn.Enabled = false;
            backbtn.Hide();
            clearbtn.Hide();
            savebtn.Hide();
            regbtn.Hide();
            label19.Hide();
          
        }

        private void bbackbtn_Click(object sender, EventArgs e)
        {
            aregistrations reg = new aregistrations();
            reg.Show();
            reg.StartPosition = FormStartPosition.Manual;
            reg.Location = new Point(345, 38);
        }
    }
}
