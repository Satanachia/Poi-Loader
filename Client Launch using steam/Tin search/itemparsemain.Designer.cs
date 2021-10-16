
namespace poiLoader
{
    partial class ItemParseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemParseMain));
            this.bsearch = new System.Windows.Forms.Button();
            this.tsearchbox = new System.Windows.Forms.TextBox();
            this.titemlist = new System.Windows.Forms.TextBox();
            this.lsettings = new System.Windows.Forms.Label();
            this.bsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rreforge = new System.Windows.Forms.RadioButton();
            this.rname = new System.Windows.Forms.RadioButton();
            this.ssavetofile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsearch
            // 
            this.bsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bsearch.FlatAppearance.BorderSize = 0;
            this.bsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bsearch.Location = new System.Drawing.Point(577, 38);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(117, 46);
            this.bsearch.TabIndex = 1;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = false;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // tsearchbox
            // 
            this.tsearchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.tsearchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsearchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tsearchbox.Location = new System.Drawing.Point(12, 38);
            this.tsearchbox.Multiline = true;
            this.tsearchbox.Name = "tsearchbox";
            this.tsearchbox.Size = new System.Drawing.Size(559, 46);
            this.tsearchbox.TabIndex = 2;
            this.tsearchbox.Text = "Search for item";
            this.tsearchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tsearchbox.Click += new System.EventHandler(this.tsearchbox_Click);
            // 
            // titemlist
            // 
            this.titemlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.titemlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titemlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titemlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.titemlist.Location = new System.Drawing.Point(12, 113);
            this.titemlist.Multiline = true;
            this.titemlist.Name = "titemlist";
            this.titemlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.titemlist.Size = new System.Drawing.Size(682, 453);
            this.titemlist.TabIndex = 3;
            // 
            // lsettings
            // 
            this.lsettings.AutoSize = true;
            this.lsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lsettings.Location = new System.Drawing.Point(12, 578);
            this.lsettings.Name = "lsettings";
            this.lsettings.Size = new System.Drawing.Size(113, 31);
            this.lsettings.TabIndex = 5;
            this.lsettings.Text = "Settings";
            this.lsettings.Click += new System.EventHandler(this.label1_Click);
            // 
            // bsave
            // 
            this.bsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bsave.FlatAppearance.BorderSize = 0;
            this.bsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bsave.Location = new System.Drawing.Point(18, 642);
            this.bsave.Name = "bsave";
            this.bsave.Size = new System.Drawing.Size(122, 34);
            this.bsave.TabIndex = 7;
            this.bsave.Text = "Select Path";
            this.bsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bsave.UseVisualStyleBackColor = false;
            this.bsave.Click += new System.EventHandler(this.bsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(14, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mabi Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tin Tsearch App";
            // 
            // rreforge
            // 
            this.rreforge.AutoSize = true;
            this.rreforge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rreforge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rreforge.Location = new System.Drawing.Point(172, 90);
            this.rreforge.Name = "rreforge";
            this.rreforge.Size = new System.Drawing.Size(108, 17);
            this.rreforge.TabIndex = 12;
            this.rreforge.TabStop = true;
            this.rreforge.Text = "Search by reforge";
            this.rreforge.UseVisualStyleBackColor = true;
            // 
            // rname
            // 
            this.rname.AutoSize = true;
            this.rname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rname.Location = new System.Drawing.Point(15, 90);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(151, 17);
            this.rname.TabIndex = 13;
            this.rname.TabStop = true;
            this.rname.Text = "Search by name / enchant";
            this.rname.UseVisualStyleBackColor = true;
            // 
            // ssavetofile
            // 
            this.ssavetofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ssavetofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ssavetofile.FlatAppearance.BorderSize = 0;
            this.ssavetofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ssavetofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssavetofile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ssavetofile.Location = new System.Drawing.Point(577, 541);
            this.ssavetofile.Name = "ssavetofile";
            this.ssavetofile.Size = new System.Drawing.Size(100, 25);
            this.ssavetofile.TabIndex = 14;
            this.ssavetofile.Text = "Save to file";
            this.ssavetofile.UseVisualStyleBackColor = false;
            this.ssavetofile.Click += new System.EventHandler(this.ssavetofile_Click);
            // 
            // ItemParseMain
            // 
            this.AcceptButton = this.bsearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(707, 695);
            this.Controls.Add(this.ssavetofile);
            this.Controls.Add(this.rname);
            this.Controls.Add(this.rreforge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bsave);
            this.Controls.Add(this.lsettings);
            this.Controls.Add(this.titemlist);
            this.Controls.Add(this.tsearchbox);
            this.Controls.Add(this.bsearch);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemParseMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item parse";
            this.Load += new System.EventHandler(this.ItemParseMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.TextBox tsearchbox;
        private System.Windows.Forms.TextBox titemlist;
        private System.Windows.Forms.Label lsettings;
        private System.Windows.Forms.Button bsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rreforge;
        private System.Windows.Forms.RadioButton rname;
        private System.Windows.Forms.Button ssavetofile;
    }
}

