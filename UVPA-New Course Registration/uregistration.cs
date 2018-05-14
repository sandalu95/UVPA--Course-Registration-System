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
    public partial class uregistration : Form
    {
        public uregistration()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("After submission you won't be able to do any changes. Only admin can change thereafter. Are you sure to submit?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }

        private void corebtn_Click(object sender, EventArgs e)
        {
            corelist.Items.Clear();
            foreach (string s in coresubbox.CheckedItems)
                corelist.Items.Add(s);
        }

        private void auxbtn_Click(object sender, EventArgs e)
        {
            auxilarylist.Items.Clear();
            foreach (string s in auxsubbox.CheckedItems)
                auxilarylist.Items.Add(s);
        }

        private void elecbtn_Click(object sender, EventArgs e)
        {
            electivelist.Items.Clear();
            foreach (string s in elecsubbox.CheckedItems)
                electivelist.Items.Add(s);
        }

        private void coresubtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            coresubbox.SelectedItems.Clear();
            for (int i = coresubbox.Items.Count - 1; i >= 0; i--)
            {
                if (coresubbox.Items[i].ToString().ToLower().Contains(coresubtxt.Text.ToLower()))
                {
                    coresubbox.SetSelected(i, true);
                }
            }
            coreno.Text = coresubbox.SelectedItems.Count.ToString() + " " + "items found";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void auxsubtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxsubbox.SelectedItems.Clear();
            for (int i = auxsubbox.Items.Count - 1; i >= 0; i--)
            {
                if (auxsubbox.Items[i].ToString().ToLower().Contains(auxsubtxt.Text.ToLower()))
                {
                    auxsubbox.SetSelected(i, true);
                }
            }
            auxno.Text = auxsubbox.SelectedItems.Count.ToString() + " " + "items found";
        }

        private void elecsubtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            elecsubbox.SelectedItems.Clear();
            for (int i = elecsubbox.Items.Count - 1; i >= 0; i--)
            {
                if (elecsubbox.Items[i].ToString().ToLower().Contains(elecsubtxt.Text.ToLower()))
                {
                    elecsubbox.SetSelected(i, true);
                }
            }
            elecno.Text = elecsubbox.SelectedItems.Count.ToString() + " " + "items found";
        }
    }
}
