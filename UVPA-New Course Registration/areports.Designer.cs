namespace UVPA_New_Course_Registration
{
    partial class areports
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
            this.reportpanel = new System.Windows.Forms.Panel();
            this.reportgenbtn = new System.Windows.Forms.Button();
            this.stureportcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reportpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportpanel
            // 
            this.reportpanel.BackColor = System.Drawing.Color.White;
            this.reportpanel.Controls.Add(this.reportgenbtn);
            this.reportpanel.Controls.Add(this.stureportcombo);
            this.reportpanel.Controls.Add(this.label3);
            this.reportpanel.Location = new System.Drawing.Point(0, 1);
            this.reportpanel.Name = "reportpanel";
            this.reportpanel.Size = new System.Drawing.Size(981, 658);
            this.reportpanel.TabIndex = 4;
            // 
            // reportgenbtn
            // 
            this.reportgenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportgenbtn.Location = new System.Drawing.Point(492, 402);
            this.reportgenbtn.Name = "reportgenbtn";
            this.reportgenbtn.Size = new System.Drawing.Size(146, 32);
            this.reportgenbtn.TabIndex = 4;
            this.reportgenbtn.Text = "Generate Report";
            this.reportgenbtn.UseVisualStyleBackColor = true;
            // 
            // stureportcombo
            // 
            this.stureportcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stureportcombo.FormattingEnabled = true;
            this.stureportcombo.Location = new System.Drawing.Point(364, 344);
            this.stureportcombo.Name = "stureportcombo";
            this.stureportcombo.Size = new System.Drawing.Size(274, 28);
            this.stureportcombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search student : ";
            // 
            // areports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.reportpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(335, 38);
            this.Name = "areports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "areports";
            this.Load += new System.EventHandler(this.areports_Load);
            this.reportpanel.ResumeLayout(false);
            this.reportpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportpanel;
        private System.Windows.Forms.Button reportgenbtn;
        private System.Windows.Forms.ComboBox stureportcombo;
        private System.Windows.Forms.Label label3;
    }
}