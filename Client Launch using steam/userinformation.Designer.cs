
namespace Client_Launch_using_steam
{
    partial class userinformation
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
            this.bsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tprofile = new System.Windows.Forms.TextBox();
            this.tuser = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tpath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bsteampath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsave
            // 
            this.bsave.Location = new System.Drawing.Point(39, 165);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(166, 23);
            this.bsave.TabIndex = 0;
            this.bsave.Text = "Save Profile";
            this.bsave.UseVisualStyleBackColor = true;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Steam user name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tprofile
            // 
            this.tprofile.Location = new System.Drawing.Point(105, 12);
            this.tprofile.Name = "tprofile";
            this.tprofile.Size = new System.Drawing.Size(100, 20);
            this.tprofile.TabIndex = 4;
            // 
            // tuser
            // 
            this.tuser.Location = new System.Drawing.Point(105, 38);
            this.tuser.Name = "tuser";
            this.tuser.Size = new System.Drawing.Size(100, 20);
            this.tuser.TabIndex = 5;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(105, 64);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(100, 20);
            this.tpass.TabIndex = 6;
            // 
            // tpath
            // 
            this.tpath.Enabled = false;
            this.tpath.Location = new System.Drawing.Point(105, 91);
            this.tpath.Name = "tpath";
            this.tpath.Size = new System.Drawing.Size(100, 20);
            this.tpath.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Path to steam";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bsteampath
            // 
            this.bsteampath.Location = new System.Drawing.Point(105, 117);
            this.bsteampath.Name = "bsteampath";
            this.bsteampath.Size = new System.Drawing.Size(100, 23);
            this.bsteampath.TabIndex = 9;
            this.bsteampath.Text = "Select steam";
            this.bsteampath.UseVisualStyleBackColor = true;
            this.bsteampath.Click += new System.EventHandler(this.bsteampath_Click);
            // 
            // userinformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 195);
            this.Controls.Add(this.bsteampath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tpath);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tuser);
            this.Controls.Add(this.tprofile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bsave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "userinformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Creater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tprofile;
        private System.Windows.Forms.TextBox tuser;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox tpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bsteampath;
    }
}