using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = usertxt.Text;
            pass = passwordtxt.Text;

            if(user=="Alpha" && pass=="Alpha" )
            {
                this.Hide();
                HOME sHome = new HOME();
                sHome.Show();


            }

            if (user == "" )
            {
                MessageBox.Show("UserName Cannot be empty");
            }

            if (pass == "")
            {
                MessageBox.Show("Password Cannot be empty");
            }
            if(user != "Alpha" && pass != "Alpha")
            {
                MessageBox.Show("Password or Username Incorrect");
            }




        }
    }
}
