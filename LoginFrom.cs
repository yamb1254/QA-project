using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_Projects
{
    public partial class LoginForm : Form
    {
        DiagnosisForm diagnose;
        RegisterForm register;
        public LoginForm()
        {
            register = new RegisterForm(this);
            InitializeComponent();
        }
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Show();
            this.Hide();
        }

        private void ExitButtonReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = BoxUsername.text;
            string password = BoxPassword.text;
            if(username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("The fields are empty please fill");
            }
            diagnose = new DiagnosisForm(username,this);
            this.Hide();
            diagnose.Show();
        }

        private void BoxUsername_OnTextChange(object sender, EventArgs e)
        {
            string userN = BoxUsername.text;
            if (userN.ToLower().Trim().Equals("username"))
            {
                BoxUsername.text = "";
            }
            
        }
    }
}
