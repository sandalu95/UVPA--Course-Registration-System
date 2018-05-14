using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UVPA_New_Course_Registration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            home = new ahome();
            home.MdiParent = this;
            home.FormClosed += Home_FormClosed;
            home.Show();
        }


        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void minilbl_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void maxilbl_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        amodules modules;
        private void moduleslbl_Click(object sender, EventArgs e)
        {
            if (modules == null)
            {
                modules = new amodules();
                modules.MdiParent = this;
                modules.FormClosed += Modules_FormClosed;
                modules.Show();
            }
            else
            {
                modules.Activate();
            }
        }

        private void Modules_FormClosed(object sender, FormClosedEventArgs e)
        {
            modules = null;
            //throw new NotImplementedException();
        }

        ahome home;
        private void homelbl_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new ahome();
                home.MdiParent = this;
                home.FormClosed += Home_FormClosed;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
            //throw new NotImplementedException();
        }

        aregistrations registrations;
        private void registrationslbl_Click(object sender, EventArgs e)
        {
            if (registrations == null)
            {
                registrations = new aregistrations();
                registrations.MdiParent = this;
                registrations.FormClosed += Registrations_FormClosed;
                registrations.Show();
            }
            else
            {
                registrations.Activate();
            }
        }

        private void Registrations_FormClosed(object sender, FormClosedEventArgs e)
        {
            registrations = null;
            //throw new NotImplementedException();
        }



        areports reports;
        private void reportslbl_Click(object sender, EventArgs e)
        {
            if (reports==null)
            {
                reports = new areports();
                reports.MdiParent = this;
                reports.FormClosed += Reports_FormClosed;
                reports.Show();
            }
            else
            {
                reports.Activate();
            }
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            reports = null;
            //throw new NotImplementedException();
        }



        asettings settings;
        private void settingslbl_Click(object sender, EventArgs e)
        {
            if (settings==null)
            {
                settings = new asettings();
                settings.MdiParent = this;
                settings.FormClosed += Settings_FormClosed;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
            //throw new NotImplementedException();
        }


        private void logoutlbl_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 f1 = new Form1();
                //aregistrations.ActiveForm.Close();
                f1.Show();  
            }

        }
    }
}
