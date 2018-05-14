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
    public partial class Form1 : Form
    {
        DBConnect conn = new DBConnect();
        public Form1()
        {
            InitializeComponent();

            conn.OpenConnection();

        }

        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = unametxt;
            unametxt.Focus();

            conn.OpenConnection();
        }


        private void forgotpwordlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Your password hint - admin", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginlbl_Click(object sender, EventArgs e)
        {
            if (conn.OpenConnection() == true)
            {
                string query= "select*from account where UserName='" + this.unametxt.Text + "' and Password='" + this.pwordtxt.Text+ "'";
                MySqlCommand SelectCommand = new MySqlCommand(query,conn.connection);
                MySqlDataReader myReader;
            
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    Form3 new_form = new Form3();
                    string uname = this.unametxt.Text;
                    string pword = this.pwordtxt.Text;
                    new_form.prop = uname;
                    new_form.prop2 = pword;
                    new_form.Show();
                    this.Hide();
                    
                }

                else if ((unametxt.Text == "admin") && (pwordtxt.Text == "admin"))
                {
                    Form2 new_form1 = new Form2();
                    string uname = this.unametxt.Text;
                    string pword = this.pwordtxt.Text;
                    asettings admin = new asettings();
                    admin.pword = pword;
                    admin.pword = pword;
                    new_form1.Show();
                    this.Hide();
                }

                /*else if ((unametxt.Text == "user") && (pwordtxt.Text == "user"))
                {
                    Form3 new_form = new Form3();
                    new_form.Show();
                    this.Hide();
                }*/
                
                else
                {
                    MessageBox.Show("Incorrect username/password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    unametxt.Text = "";
                    pwordtxt.Text = "";
                    unametxt.Focus();
                }
            }
                conn.CloseConnection();
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (msg.WParam.ToInt64() == (int)Keys.Escape)
                {
                    DialogResult result = MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            catch
            {
                MessageBox.Show("Type in the given fields..!");
            }
            return false;
        }

        private void unametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pwordtxt.Focus();
            }
        }

        private void pwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginlbl_Click(sender, e);
            }
        }

       
    }
}
