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
    public partial class Airtym2 : Form
    {
        public Airtym2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Airtime air = new Airtime();
            air.Show();
        }

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {
            string phone = phoneNum.Text; 
        }
    }
}
