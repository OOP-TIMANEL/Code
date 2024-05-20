using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_system
{
    public partial class SplashForm2 : Form
    {
        public SplashForm2()
        {
            InitializeComponent();
        }

        private void SplashForm2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            myProgressBar.Value = startPoint;
            if (myProgressBar.Value == 100 )
            {
                myProgressBar.Value = 0;
                timer1.Stop();
                Form1 loginForm = new Form1();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
