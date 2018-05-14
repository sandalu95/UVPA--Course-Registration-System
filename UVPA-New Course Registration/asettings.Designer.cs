namespace UVPA_New_Course_Registration
{
    partial class asettings
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
            this.settingspanel = new System.Windows.Forms.Panel();
            this.savebtn = new System.Windows.Forms.Button();
            this.confirmpwordtxt = new System.Windows.Forms.TextBox();
            this.newpwordtxt = new System.Windows.Forms.TextBox();
            this.currentpwordtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settingspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingspanel
            // 
            this.settingspanel.Controls.Add(this.savebtn);
            this.settingspanel.Controls.Add(this.confirmpwordtxt);
            this.settingspanel.Controls.Add(this.newpwordtxt);
            this.settingspanel.Controls.Add(this.currentpwordtxt);
            this.settingspanel.Controls.Add(this.label7);
            this.settingspanel.Controls.Add(this.label6);
            this.settingspanel.Controls.Add(this.label5);
            this.settingspanel.Controls.Add(this.label4);
            this.settingspanel.Location = new System.Drawing.Point(0, 0);
            this.settingspanel.Name = "settingspanel";
            this.settingspanel.Size = new System.Drawing.Size(981, 658);
            this.settingspanel.TabIndex = 6;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(627, 388);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 33);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // confirmpwordtxt
            // 
            this.confirmpwordtxt.BackColor = System.Drawing.Color.White;
            this.confirmpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpwordtxt.Location = new System.Drawing.Point(448, 330);
            this.confirmpwordtxt.Name = "confirmpwordtxt";
            this.confirmpwordtxt.PasswordChar = '*';
            this.confirmpwordtxt.Size = new System.Drawing.Size(255, 26);
            this.confirmpwordtxt.TabIndex = 6;
            // 
            // newpwordtxt
            // 
            this.newpwordtxt.BackColor = System.Drawing.Color.White;
            this.newpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwordtxt.Location = new System.Drawing.Point(448, 284);
            this.newpwordtxt.Name = "newpwordtxt";
            this.newpwordtxt.PasswordChar = '*';
            this.newpwordtxt.Size = new System.Drawing.Size(255, 26);
            this.newpwordtxt.TabIndex = 5;
            // 
            // currentpwordtxt
            // 
            this.currentpwordtxt.BackColor = System.Drawing.Color.White;
            this.currentpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentpwordtxt.Location = new System.Drawing.Point(448, 239);
            this.currentpwordtxt.Name = "currentpwordtxt";
            this.currentpwordtxt.PasswordChar = '*';
            this.currentpwordtxt.Size = new System.Drawing.Size(255, 26);
            this.currentpwordtxt.TabIndex = 4;
            this.currentpwordtxt.TextChanged += new System.EventHandler(this.currentpwordtxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Confirm password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "New password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Current password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Do you want to change password?";
            // 
            // asettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.settingspanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(335, 38);
            this.Name = "asettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "asettings";
            this.settingspanel.ResumeLayout(false);
            this.settingspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingspanel;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox confirmpwordtxt;
        private System.Windows.Forms.TextBox newpwordtxt;
        private System.Windows.Forms.TextBox currentpwordtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}