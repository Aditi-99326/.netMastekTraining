using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //username - admin and password - 123

            //txtUsername.Text ----- username
            //txtpwd.Text ----- passaword

            //lblmsg.Text = "valid user";
            //lblmsg.Text = "Invalid username or passaword";

            if (txtUserName.Text == "admin" && txtPassaword.Text == "123")
            {
                lblMsg.Text = "Valid User";

            }
            else
            {
                lblMsg.Text = "Invalid UserName or passaword";
            }
        }

        
    }
}
