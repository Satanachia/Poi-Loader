using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Launch_using_steam
{
    public partial class userinformation : Form
    {
        public userinformation()
        {
            InitializeComponent();
        }
        string sFileName = "";
        private void bsteampath_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (steam.exe)|steam.exe";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;

            }
            tpath.Text = sFileName;
        }

        private void bsave_Click(object sender, EventArgs e)
        {
            bool exists = false;
            using (var reader = new StreamReader(@"profile.csv"))
            {
                
                List<string> lProfile = new List<string>();
                List<string> lUser = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    lProfile.Add(values[0]);
                    lUser.Add(values[1]);
                }

                foreach (string str in lUser)
                {
                    if (str == tuser.Text)
                    {
                        exists = true;
                    }
                    else
                    {
                        exists = false;
                    }
                }

                


            }
            if (!exists)
            {
                var filePath = @"profile.csv";
                var csv = new StringBuilder();

                var profile = tprofile.Text;
                var user = tuser.Text;
                var pass = tpass.Text;
                var path = tpath.Text;




                //Suggestion made by KyleMit
                var newLine = string.Format("{0},{1},{2},{3}", profile, user, pass, path);
                csv.AppendLine(newLine);
                File.AppendAllText(filePath, csv.ToString());
                MessageBox.Show("saved to file,\r\nyou will need to reopen the program for the list to update :c");
                this.Close();
            }
            else
            {
                MessageBox.Show("this account already exists, not using");
            }
        }
    }
}
