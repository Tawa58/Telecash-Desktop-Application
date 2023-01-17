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
    public partial class Airtime : Form
    {
        public Airtime()
        {
            InitializeComponent();
        }

        private void Others_CheckedChanged(object sender, EventArgs e)
        {
            Airtym2 obj = new Airtym2(); 
           obj.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAirtime.Text);
            Sendmoney obj = new Sendmoney();
            double bal = 20000;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
