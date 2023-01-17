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
    public partial class Sendmoney : Form
    {
        public Sendmoney()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
           string  Phone = txtPhone.Text;
           double Amount = Convert.ToDouble(txtAmnt.Text);
           double amount;
           double balance = 1000000.0;
            if(Amount < balance ) 
            {
                balance = balance - Amount;
                MessageBox.Show("You have sent Rtgs $"+Amount+" to "+Phone);
            }
            else if (Amount > balance)
            {
                string message = "YOU HAVE INSUFFICIENT FUNDS ";
                string tittle = "confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result = MessageBox.Show(message, tittle, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                    // craeting an object of the home page 
                    Home home = new Home();
                    home.Show();
                }
            }
            else if (Phone == "" && Amount.ToString() ==" ")
            {
                MessageBox.Show("You have entered invalid details "+MessageBoxButtons.OK);
    
            }
        }
    }
}
