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
        }

        List<string> lProfile = new List<string>();
        List<string> lUser = new List<string>();
        List<string> lPass = new List<string>();
        List<string> lPath = new List<string>();
        

        private void button2_Click(object sender, EventArgs e)
        {
            userinformation userinformation = new userinformation();
            userinformation.ShowDialog();
        }

        private void blaunch_Click(object sender, EventArgs e)
        {
            string path = lPath[comboBox1.SelectedIndex];
            string user = lUser[comboBox1.SelectedIndex];
            string pass = lPass[comboBox1.SelectedIndex];

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
            }

            }
            

        private void Form1_Load(object sender, EventArgs e)
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

                    lProfile.Add(values[0]);
                    lUser.Add(values[1]);
                    lPass.Add(values[2]);
                    lPath.Add(values[3]);
                }

                for (int i = 0; i <= lProfile.Count - 1; i++)
                {
                    comboBox1.Items.Add(lProfile[i]);
                }
            }

            comboBox1.SelectedIndex = 0;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lUser[comboBox1.SelectedIndex];
            textBox2.Text = lPass[comboBox1.SelectedIndex];
            textBox3.Text = lPath[comboBox1.SelectedIndex];
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
                string path = lPath[comboBox1.SelectedIndex];
                string user = lUser[comboBox1.SelectedIndex];
                string pass = lPass[comboBox1.SelectedIndex];
                

                launch(user, pass, path, true);
                for (int i = 1; i <= Decimal.ToInt32(nofclient.Value -1); i++)
                {
                    path = lPath[comboBox1.SelectedIndex + i];
                    user = lUser[comboBox1.SelectedIndex + i];
                    pass = lPass[comboBox1.SelectedIndex + i];
                    
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


    }
}

