using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;


namespace poiLoader
{
    public partial class ItemParseMain : Form
    {

        //char has to be gobal for this form
        List<Character> mychars = new List<Character>();
        string path = "";
        bool onlyclearonce = false;
        string localpath = "";


        public ItemParseMain()
        {

            InitializeComponent();
            
        }


        private void ItemParseMain_Load(object sender, EventArgs e)
        {
            
            
            localpath = Directory.GetCurrentDirectory();
            localpath += @"\config.txt";

            rname.Checked = true;
            if (!File.Exists(localpath))
            {
                using (StreamWriter sw = File.CreateText(localpath)) { }
                MessageBox.Show("please enter mabinogi path");
                

            }
            else
            {
                path = File.ReadLines(localpath).First();
                Console.WriteLine(localpath);
            }
            
;



        }
        private void tsearchbox_Click(object sender, EventArgs e)
        {
            if (!onlyclearonce)
            {
                tsearchbox.Clear();
                onlyclearonce = true;
            }
            
        }

        private void bsearch_Click(object sender, EventArgs e)
        {
            if (mychars.Count != 0)
            {
                mychars.Clear();
            }
            
            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                
                Readitemfile.readitemfile(mychars, file);
            }
            string search = tsearchbox.Text.ToLower();
            titemlist.Text = "";
            List<Character> charwithitem = new List<Character>();
            if (rname.Checked) {
                for (int i = 0; i < mychars.Count; i++)
                {

                    if (mychars[i].hasitem(search))
                    {
                        charwithitem.Add(mychars[i]);
                    }

                }

                foreach (Character chara in charwithitem)
                {
                    Console.WriteLine(chara.Charname);
                    titemlist.Text += chara.Charname;
                    if (!chara.Charname.Contains("Bank"))
                    {
                        titemlist.Text += "\t(summon command, only works on pets) \t\t summon " + chara.Charname + "!";
                    }
                    titemlist.Text += "\r\n";
                    titemlist.Text += "=========================================================================\r\n\r\n";




                    foreach (var item in chara.MyList)
                    {
                        string name = item.name.ToLower();
                        if (item.name.Contains(search))
                        {
                            titemlist.Text += "Item name: " + item.name;
                            titemlist.Text += "\r\n";
                            titemlist.Text += "Class id: " + item.classid.ToString();
                            titemlist.Text += "\r\n";
                            titemlist.Text += "item coords = x:" + item.xpos + " y:" + item.ypos;
                            titemlist.Text += "\r\n\r\n\r\n";
                        }
                    }
                }
            }
            if (rreforge.Checked)
            {
                for (int i = 0; i < mychars.Count; i++)
                {

                    if (mychars[i].hasreforge(search))
                    {
                        charwithitem.Add(mychars[i]);
                    }

                }
                foreach (Character chara in charwithitem)
                {
                    Console.WriteLine(chara.Charname);
                    titemlist.Text += chara.Charname;
                    if (!chara.Charname.Contains("Bank"))
                    {
                        titemlist.Text += "\t(summon command, only works on pets) \t\t summon " + chara.Charname + "!";
                    }
                    titemlist.Text += "\r\n";
                    titemlist.Text += "=========================================================================\r\n\r\n";




                    foreach (var item in chara.MyList)
                    {

                        if (item.hasreforge(search))
                        {
                            titemlist.Text += "Item name: " + item.name;
                            titemlist.Text += "\r\n";
                            titemlist.Text += "Class id: " + item.classid.ToString();
                            titemlist.Text += "\r\n";
                            titemlist.Text += "item coords = x:" + item.xpos + " y:" + item.ypos;
                            titemlist.Text += "\r\n";
                            titemlist.Text += "item reforges = \r\n";
                            foreach (string reforge in item.reforges)
                            {
                                titemlist.Text += "\t" + reforge + "\r\n";
                            }
                            titemlist.Text += "\r\n\r\n\r\n";
                        }
                    }
                }
            }
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            
        }

        private void bsave_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath;  //selected folder path

                
                path = folder;
                path += @"\SavedItems\";
                File.WriteAllText(localpath, path);
                foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
                {
                    Console.WriteLine(file);
                    Readitemfile.readitemfile(mychars, file);
                }

            }
            path = File.ReadLines(localpath).First();
            Console.WriteLine(localpath);


        }





















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tsettings_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) {

            }
        }

        private void ssavetofile_Click(object sender, EventArgs e)
        {
            string savefile = Directory.GetCurrentDirectory();
            savefile += @"/output.txt";
            File.WriteAllText(savefile, titemlist.Text);
            MessageBox.Show("saved output to (output.txt) opening file in text editor");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = savefile,
                UseShellExecute = true,
                Verb = "open"
            });


        }
    }
}

