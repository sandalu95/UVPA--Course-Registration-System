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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string prop { get; set; }
        public string prop2 { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minilbl_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
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

        uhome home;
        private void homelbl_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new uhome();
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

        ustuinfo stuinfo;
        private void stuinfolbl_Click(object sender, EventArgs e)
        {
            if (stuinfo == null)
            {
                stuinfo = new ustuinfo();
                stuinfo.MdiParent = this;
                stuinfo.FormClosed += Stuinfo_FormClosed;
                stuinfo.Show();
            }
            else
            {
                stuinfo.Activate();
            }
        }

        private void Stuinfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            stuinfo = null;
            //throw new NotImplementedException();
        }

        private void logoutlbl_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form3.ActiveForm.Close();
                //aregistrations.ActiveForm.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                home = new uhome();
                home.MdiParent = this;
                home.FormClosed += Home_FormClosed;
                home.Show();
        }

        usettings settings;
        private void settingslbl_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new usettings();
                settings.pro = prop;
                settings.pro2 = prop2;
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

        uregistration registrations;
        private void reglbl_Click(object sender, EventArgs e)
        {
            if (registrations == null)
            {
                registrations = new uregistration();
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

        uprereg prereg;
        private void prereglbl_Click(object sender, EventArgs e)
        {
            if (prereg == null)
            {
                prereg = new uprereg();
                prereg.MdiParent = this;
                prereg.FormClosed += Prereg_FormClosed;
                prereg.Show();
            }
            else
            {
                prereg.Activate();
            }
        }

        private void Prereg_FormClosed(object sender, FormClosedEventArgs e)
        {
            prereg = null;
           // throw new NotImplementedException();
        }
    }
}
