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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sendmoney send = new Sendmoney();
            this.Hide();
            send.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Airtime buy = new Airtime();
            buy.Show();
        }
    }
}
