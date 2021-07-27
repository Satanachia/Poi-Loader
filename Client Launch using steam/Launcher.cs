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


namespace Client_Launch_using_steam
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
            comboBox1.Items.Add(profiles[profiles.Count-1].profileName);

        }

        private void blaunch_Click(object sender, EventArgs e)
        {
            string path = Profiles[comboBox1.SelectedIndex].SteamPath;
            string user = Profiles[comboBox1.SelectedIndex].userName;
            string pass = Profiles[comboBox1.SelectedIndex].password;

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
                    Thread.Sleep(Decimal.ToInt32(ntimetoclose.Value) * 1000);
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

                    comboBox1.Items.Add(Profiles[i].profileName);
                }
            }

            comboBox1.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            loadprofiles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Profiles[comboBox1.SelectedIndex].userName;
            textBox2.Text = Profiles[comboBox1.SelectedIndex].password;
            textBox3.Text = Profiles[comboBox1.SelectedIndex].SteamPath;
        }

        private void launchxclients_Click(object sender, EventArgs e)
        {
            int launcnum = Decimal.ToInt32(nofclient.Value);
            if (Decimal.ToInt32(nofclient.Value) <= 0 || Decimal.ToInt32(nofclient.Value) <= 1)
            {
                MessageBox.Show("please pick 2 or more");
            }
            else
            {
                string path = Profiles[comboBox1.SelectedIndex].SteamPath;
                string user = Profiles[comboBox1.SelectedIndex].userName;
                string pass = Profiles[comboBox1.SelectedIndex].password;
                

                launch(user, pass, path, true);
                for (int i = 1; i <= Decimal.ToInt32(nofclient.Value -1); i++)
                {
                    path = Profiles[comboBox1.SelectedIndex + i].SteamPath;
                    user = Profiles[comboBox1.SelectedIndex + i].userName;
                    pass = Profiles[comboBox1.SelectedIndex + i].password;

                    launch(user, pass, path, true);
                }

            }

        }


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
                string path = Profiles[comboBox1.SelectedIndex].SteamPath;
                string user = Profiles[comboBox1.SelectedIndex].userName;
                string pass = Profiles[comboBox1.SelectedIndex].password;
                Process test = new Process();
                test.StartInfo.FileName = path;
                test.StartInfo.Arguments = @"-login " + user + @" " + pass;
                test.Start();
            }
        }
    }
}

