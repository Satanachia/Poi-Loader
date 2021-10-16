using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poiLoader
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        Launcher launch = new Launcher() { TopLevel = false, TopMost = true };
        ItemParseMain search = new ItemParseMain()  { TopLevel = false, TopMost = true };
        // 1 = launcher
        // 2 = search
        //
        //
        //
        int currentscreen = 0;

        private void blaunch_Click(object sender, EventArgs e)
        {

            loadlaunch();

        }

        private void hideall()
        {
            launch.Hide();
            search.Hide();
        }
        private void loadlaunch()
        {
            if (currentscreen == 1)
            {

            }
            else
            {
                Size = new Size(470, 417);
                hideall();
                phold.Controls.Clear();
                phold.Controls.Add(launch);
                launch.Show();
                currentscreen = 1;
            }
        }
        private void loadsearch()
        {
            if (currentscreen == 2)
            {

            }
            else
            {
                Size = new Size(894, 695);
                hideall();
                phold.Controls.Clear();
                phold.Controls.Add(search);
                search.Show();
                currentscreen = 2;
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            loadlaunch();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            loadsearch();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
