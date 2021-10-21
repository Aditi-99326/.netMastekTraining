using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFAssignment.Models;


namespace EFAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            TrainingContext db = new TrainingContext();
            
            string uname = txtUserName.Text;
            string pwd = txtPassword.Text;

            //db.Userdata.SingleOrDefault(e => e.Username ==  txtUserName.Text && e.Password == txtPassword.Text);



            Userdatum user = db.Userdata.SingleOrDefault(e => e.Username == txtUserName.Text && e.Password == txtPassword.Text);
            if (user != null)
            {
                lblMSG.Text = "Valid user";
            }
            else
            {
                lblMSG.Text = "Invalid user or password";
            }
        }
    }
}
