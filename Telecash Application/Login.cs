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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string pass = txtPass.Text;
            pass = "1234";
            //User use = new User();
           // use.pass = 1234;
            if (username == "tawanda" && pass == "1234")
            {
               this.Hide();
                Home obj = new Home();
                obj.Show();
                 //Form1.Close();
       }
            else 
                MessageBox.Show("No");
        }
    }
}
