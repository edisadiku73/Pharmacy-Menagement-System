using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyMenagementSystem
{
    public partial class Form1 : Form
    {
        int startpoint =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            progressBar1.Value = startpoint;
            if(progressBar1.Value == 100 ) 
            {
                progressBar1.Value = 0;
                timer1.Stop();  
                Login mylogin = new Login();
                this.Hide();
                mylogin.Show();
            }
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
