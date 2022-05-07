using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace QA_Projects
{
    public partial class RegisterForm : Form
    {
        string username;
        string passw;
        string email;
        string name;
        LoginForm login;
       // private string FileName = @"C:\data.xlsx"
        public RegisterForm(LoginForm login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void LinkLabelHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.Show();
            this.Hide();
           
        }

        private void ExitButtonReg_Click(object sender, EventArgs e)
        {
           this.Close();
            this.login.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = TextboxUser.Text;
            string passw = TextboxPassword.Text;
            string email = TextboxEmail.Text;
            string name = TextboxFname.Text;
            if (username == string.Empty || passw == string.Empty || email == string.Empty || name == string.Empty)
            {
                MessageBox.Show("The fields are empty please fill");
            }

        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
