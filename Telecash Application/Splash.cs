using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 20)
            {
               progressBar1.Value +=10;
             
            }
            else if (progressBar1.Value ==100)
            {
                this.Hide();
                Login log = new Login();
            }
            /*else if (progressBar1.Value==40)
            {
                label2.Text = "Connecting to the servers.......";
            }
            else if (progressBar1.Value == 80)
            {
                label2.Text = "Checking accounts.......";
            }
            else if (progressBar1.Value == 100)
            {
                label2.Text = "Finishin.......";
                Login log = new Login();
                log.Show();
            }*/
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
