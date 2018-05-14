using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UVPA_New_Course_Registration
{
    public partial class uhome : Form
    {
        public uhome()
        {
            InitializeComponent();
        }

        private void gobtn_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openfiledialog1 = new OpenFileDialog();
            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pdfreader.src = openfiledialog1.FileName;
            }*/
            //pdfreader.src = "C:\Users\sandalu\Desktop\program\docs\RelationalSchema.pdf";
            Process.Start(@"C:\Users\sandalu\Desktop\program\docs\RelationalSchema.pdf");
        }
    }
}
