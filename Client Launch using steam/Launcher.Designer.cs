
namespace Client_Launch_using_steam
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.button2 = new System.Windows.Forms.Button();
            this.blaunch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checksteam = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ntimetoclose = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.launchxclients = new System.Windows.Forms.Button();
            this.nofclient = new System.Windows.Forms.NumericUpDown();
            this.bkill = new System.Windows.Forms.Button();
            this.tpid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bkillsteam = new System.Windows.Forms.Button();
            this.Steamnoclient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntimetoclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofclient)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create profile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blaunch
            // 
            this.blaunch.Location = new System.Drawing.Point(13, 214);
            this.blaunch.Name = "blaunch";
            this.blaunch.Size = new System.Drawing.Size(75, 23);
            this.blaunch.TabIndex = 6;
            this.blaunch.Text = "Launch";
            this.blaunch.UseVisualStyleBackColor = true;
            this.blaunch.Click += new System.EventHandler(this.blaunch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checksteam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ntimetoclose);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected account details";
            // 
            // checksteam
            // 
            this.checksteam.AutoSize = true;
            this.checksteam.Location = new System.Drawing.Point(6, 93);
            this.checksteam.Name = "checksteam";
            this.checksteam.Size = new System.Drawing.Size(107, 17);
            this.checksteam.TabIndex = 16;
            this.checksteam.Text = "Close steam after";
            this.checksteam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "seconds";
            // 
            // ntimetoclose
            // 
            this.ntimetoclose.Location = new System.Drawing.Point(116, 92);
            this.ntimetoclose.Name = "ntimetoclose";
            this.ntimetoclose.Size = new System.Drawing.Size(68, 20);
            this.ntimetoclose.TabIndex = 14;
            this.ntimetoclose.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select steam profile";
            // 
            // launchxclients
            // 
            this.launchxclients.Location = new System.Drawing.Point(187, 214);
            this.launchxclients.Name = "launchxclients";
            this.launchxclients.Size = new System.Drawing.Size(121, 23);
            this.launchxclients.TabIndex = 13;
            this.launchxclients.Text = "Launch x cleints";
            this.launchxclients.UseVisualStyleBackColor = true;
            this.launchxclients.Click += new System.EventHandler(this.launchxclients_Click);
            // 
            // nofclient
            // 
            this.nofclient.Location = new System.Drawing.Point(314, 214);
            this.nofclient.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nofclient.Name = "nofclient";
            this.nofclient.Size = new System.Drawing.Size(39, 20);
            this.nofclient.TabIndex = 14;
            // 
            // bkill
            // 
            this.bkill.Location = new System.Drawing.Point(13, 238);
            this.bkill.Name = "bkill";
            this.bkill.Size = new System.Drawing.Size(75, 23);
            this.bkill.TabIndex = 15;
            this.bkill.Text = "Kill all clients";
            this.bkill.UseVisualStyleBackColor = true;
            this.bkill.Click += new System.EventHandler(this.bkill_Click);
            // 
            // tpid
            // 
            this.tpid.Location = new System.Drawing.Point(223, 240);
            this.tpid.Name = "tpid";
            this.tpid.Size = new System.Drawing.Size(124, 20);
            this.tpid.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Char name of main client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "You need to rename your cleint for this to work";
            // 
            // bkillsteam
            // 
            this.bkillsteam.Location = new System.Drawing.Point(214, 26);
            this.bkillsteam.Name = "bkillsteam";
            this.bkillsteam.Size = new System.Drawing.Size(75, 23);
            this.bkillsteam.TabIndex = 20;
            this.bkillsteam.Text = "Kill Steam";
            this.bkillsteam.UseVisualStyleBackColor = true;
            this.bkillsteam.Click += new System.EventHandler(this.bkillsteam_Click);
            // 
            // Steamnoclient
            // 
            this.Steamnoclient.Location = new System.Drawing.Point(129, 26);
            this.Steamnoclient.Name = "Steamnoclient";
            this.Steamnoclient.Size = new System.Drawing.Size(79, 23);
            this.Steamnoclient.TabIndex = 21;
            this.Steamnoclient.Text = "Open steam";
            this.Steamnoclient.UseVisualStyleBackColor = true;
            this.Steamnoclient.Click += new System.EventHandler(this.Steamnoclient_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(361, 285);
            this.Controls.Add(this.Steamnoclient);
            this.Controls.Add(this.bkillsteam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tpid);
            this.Controls.Add(this.bkill);
            this.Controls.Add(this.nofclient);
            this.Controls.Add(this.launchxclients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.blaunch);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntimetoclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nofclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button blaunch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button launchxclients;
        private System.Windows.Forms.NumericUpDown nofclient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ntimetoclose;
        private System.Windows.Forms.CheckBox checksteam;
        private System.Windows.Forms.Button bkill;
        private System.Windows.Forms.TextBox tpid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bkillsteam;
        private System.Windows.Forms.Button Steamnoclient;
    }
}

