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

namespace poiLoader
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
                account newAccoutn = new account(tprofile.Text, tuser.Text, tpass.Text, tpath.Text) ;
                Launcher.Profiles.Add(newAccoutn);
                



                //Suggestion made by KyleMit
                var newLine = string.Format("{0},{1},{2},{3}", newAccoutn.profileName, newAccoutn.userName, newAccoutn.password, newAccoutn.SteamPath);
                csv.AppendLine(newLine);
                File.AppendAllText(filePath, csv.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("this account already exists, not using");
            }
        }
    }
}
