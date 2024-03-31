using System;
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
            timer.Interval = 3000; // 3000 milliseconds = 3 seconds
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            
            Form1 new_form = new Form1();
            new_form.Show();

            this.Hide();
        }

        private void round1_Click(object sender, EventArgs e)
        {

        }
    }
}
