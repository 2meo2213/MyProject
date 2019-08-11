namespace Pain
{
    partial class Form2
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
            this.lstTeam2 = new System.Windows.Forms.ListBox();
            this.lstTeam1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTeam2
            // 
            this.lstTeam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTeam2.FormattingEnabled = true;
            this.lstTeam2.Location = new System.Drawing.Point(3, 16);
            this.lstTeam2.Name = "lstTeam2";
            this.lstTeam2.Size = new System.Drawing.Size(291, 323);
            this.lstTeam2.TabIndex = 1;
            // 
            // lstTeam1
            // 
            this.lstTeam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTeam1.FormattingEnabled = true;
            this.lstTeam1.Location = new System.Drawing.Point(3, 16);
            this.lstTeam1.Name = "lstTeam1";
            this.lstTeam1.Size = new System.Drawing.Size(291, 323);
            this.lstTeam1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTeam2);
            this.groupBox2.Location = new System.Drawing.Point(399, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 342);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTeam1);
            this.groupBox1.Location = new System.Drawing.Point(51, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 342);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team 1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lstTeam1;
        public System.Windows.Forms.ListBox lstTeam2;
    }
}