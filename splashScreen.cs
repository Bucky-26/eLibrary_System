using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class splashScreen : Form
    {
        private Timer timer;
        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000; // 3 seconds
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Form1 new_form = new Form1();
            this.Hide();
            new_form.Show();
        }

    }
}
