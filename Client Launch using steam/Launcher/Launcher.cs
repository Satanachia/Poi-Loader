using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace poiLoader
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            textBox2.PasswordChar = '■';
            textBox2.MaxLength = 14;
        }
        private static List<account> profiles = new List<account>();


        internal static List<account> Profiles { get => profiles; set => profiles = value; }




        private void button2_Click(object sender, EventArgs e)
        {
            userinformation userinformation = new userinformation();
            userinformation.ShowDialog();
            mbaccountlist.Items.Add(profiles[profiles.Count-1].profileName);

        }

        private void blaunch_Click(object sender, EventArgs e)
        {
            string path = Profiles[mbaccountlist.SelectedIndex].SteamPath;
            string user = Profiles[mbaccountlist.SelectedIndex].userName;
            string pass = Profiles[mbaccountlist.SelectedIndex].password;

            launch(user, pass, path, checksteam.Checked) ;

        }


        void launch(string user, string pass, string path,bool closesteam)
        {
            {
                Process test = new Process();
                test.StartInfo.FileName = path;
                test.StartInfo.Arguments = @"-login " + user + @" " + pass + @" -applaunch 212200";
                test.Start();
                //todo get a list of pids of current running mabis
                //when new pid gets added then close steam to remove need for wait
                if(closesteam)
                {
                    int time = int.Parse(ttime.Text);
                    Thread.Sleep(time * 1000);
                    killsteam();
                }
            }

            }
            
        void killsteam()
        {
            
            try
            {
                foreach (Process proc in Process.GetProcessesByName("steam"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                foreach (Process proc in Process.GetProcessesByName("etracer"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                foreach (Process proc in Process.GetProcessesByName("steamwebhelper"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                foreach (Process proc in Process.GetProcessesByName("nxsteam"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadprofiles()
        {
            
            bool fileexist = File.Exists(@"profile.csv");
            
            if (!fileexist)
            {
                using (var file = File.Create(@"profile.csv"))
                {
                }

                userinformation userinformation = new userinformation();
                userinformation.ShowDialog();
            }

            using (var reader = new StreamReader(@"profile.csv"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Profiles.Add(new account(values[0], values[1], values[2], values[3]));
                }

                for (int i = 0; i <= Profiles.Count - 1; i++)
                {
                    mbaccountlist.Items.Add(Profiles[i].profileName);
                }
            }
            mbaccountlist.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ttime.Text = "30";
            loadprofiles();
        }



        private void launchxclients_Click(object sender, EventArgs e)
        {

            int launcnum = int.Parse(tlauncnum.Text);
            if (launcnum <= 0 || launcnum <= 1)
            {
                MessageBox.Show("please pick 2 or more");
            }
            else
            {
                string path = Profiles[mbaccountlist.SelectedIndex].SteamPath;
                string user = Profiles[mbaccountlist.SelectedIndex].userName;
                string pass = Profiles[mbaccountlist.SelectedIndex].password;
                

                launch(user, pass, path, true);
                for (int i = 1; i <= launcnum -1 ; i++)
                {
                    path = Profiles[mbaccountlist.SelectedIndex + i].SteamPath;
                    user = Profiles[mbaccountlist.SelectedIndex + i].userName;
                    pass = Profiles[mbaccountlist.SelectedIndex + i].password;

                    launch(user, pass, path, true);
                }

            }

        }
        //xc;ojkfhsado;fk

        private void bkill_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Client"))
                {
                    string clientname = proc.MainWindowTitle.ToLower();
                    
                    if (!clientname.Contains(tpid.Text.ToLower()))
                        {
                        proc.Kill();
                        }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bkillsteam_Click(object sender, EventArgs e)
        {
            killsteam();
        }

        private void Steamnoclient_Click(object sender, EventArgs e)
        {
            {
                string path = Profiles[mbaccountlist.SelectedIndex].SteamPath;
                string user = Profiles[mbaccountlist.SelectedIndex].userName;
                string pass = Profiles[mbaccountlist.SelectedIndex].password;
                Process test = new Process();
                test.StartInfo.FileName = path;
                test.StartInfo.Arguments = @"-login " + user + @" " + pass;
                test.Start();
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemParseMain itemsearch = new ItemParseMain();
            itemsearch.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void mbaccountlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Profiles[mbaccountlist.SelectedIndex].userName;
            textBox2.Text = Profiles[mbaccountlist.SelectedIndex].password;
            textBox3.Text = Profiles[mbaccountlist.SelectedIndex].SteamPath;

        }
    }
}

