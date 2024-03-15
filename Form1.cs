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
    public partial class Form1 : Form
    {
        public Form1()
        {
            splashScreen newScreen = new splashScreen();
            newScreen.Dispose();
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_home newHome = new frm_home();
            this.Hide();
            newHome.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
