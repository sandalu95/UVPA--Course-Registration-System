namespace UVPA_New_Course_Registration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.unametxt = new System.Windows.Forms.TextBox();
            this.pwordtxt = new System.Windows.Forms.TextBox();
            this.closelbl = new System.Windows.Forms.Label();
            this.forgotpwordlbl = new System.Windows.Forms.LinkLabel();
            this.loginlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // unametxt
            // 
            this.unametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametxt.Location = new System.Drawing.Point(126, 229);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(184, 15);
            this.unametxt.TabIndex = 0;
            this.unametxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unametxt_KeyDown);
            // 
            // pwordtxt
            // 
            this.pwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordtxt.Location = new System.Drawing.Point(125, 324);
            this.pwordtxt.Name = "pwordtxt";
            this.pwordtxt.PasswordChar = '*';
            this.pwordtxt.Size = new System.Drawing.Size(184, 15);
            this.pwordtxt.TabIndex = 1;
            this.pwordtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwordtxt_KeyDown);
            // 
            // closelbl
            // 
            this.closelbl.BackColor = System.Drawing.Color.Transparent;
            this.closelbl.Location = new System.Drawing.Point(369, 4);
            this.closelbl.Name = "closelbl";
            this.closelbl.Size = new System.Drawing.Size(20, 19);
            this.closelbl.TabIndex = 3;
            this.closelbl.Click += new System.EventHandler(this.closelbl_Click);
            // 
            // forgotpwordlbl
            // 
            this.forgotpwordlbl.AutoSize = true;
            this.forgotpwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.forgotpwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpwordlbl.Location = new System.Drawing.Point(80, 456);
            this.forgotpwordlbl.Name = "forgotpwordlbl";
            this.forgotpwordlbl.Size = new System.Drawing.Size(148, 16);
            this.forgotpwordlbl.TabIndex = 6;
            this.forgotpwordlbl.TabStop = true;
            this.forgotpwordlbl.Text = "Forgot Your Password?";
            this.forgotpwordlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpwordlbl_LinkClicked);
            // 
            // loginlbl
            // 
            this.loginlbl.BackColor = System.Drawing.Color.Transparent;
            this.loginlbl.Location = new System.Drawing.Point(154, 380);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(93, 37);
            this.loginlbl.TabIndex = 7;
            this.loginlbl.Click += new System.EventHandler(this.loginlbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(396, 545);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.forgotpwordlbl);
            this.Controls.Add(this.closelbl);
            this.Controls.Add(this.pwordtxt);
            this.Controls.Add(this.unametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox pwordtxt;
        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.Label closelbl;
        private System.Windows.Forms.LinkLabel forgotpwordlbl;
        private System.Windows.Forms.Label loginlbl;
    }
}