namespace UVPA_New_Course_Registration
{
    partial class uhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uhome));
            this.homepanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.homepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // homepanel
            // 
            this.homepanel.Controls.Add(this.label3);
            this.homepanel.Controls.Add(this.label2);
            this.homepanel.Controls.Add(this.gobtn);
            this.homepanel.Controls.Add(this.label1);
            this.homepanel.Location = new System.Drawing.Point(0, 0);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(981, 658);
            this.homepanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(141, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "About the system";
            // 
            // gobtn
            // 
            this.gobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.Location = new System.Drawing.Point(129, 265);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(75, 38);
            this.gobtn.TabIndex = 1;
            this.gobtn.Text = "Go";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalogue???";
            // 
            // uhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.homepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(335, 38);
            this.Name = "uhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "uhome";
            this.homepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.Label label1;
    }
}