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
        LoginForm login;
        const int UsernameCol = 2, PasswordCol = 4 ,Namecol = 1, Emailcol = 3;
        string FileName = System.IO.Path.GetFullPath("LoginInfo.xlsx");
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
            string passwCon = TextboxCpass.Text;
            string[] vs = new string[] { name, username, email, passw };  
            Excel excel = new Excel(FileName, 1);
            if (username == string.Empty || passw == string.Empty || email == string.Empty || name == string.Empty || passwCon == string.Empty)
            {
                MessageBox.Show("The fields are empty please fill");
            }
            else if (passw.Length > 16 || passw.Length < 8)
            {
                MessageBox.Show("The password must have between 8-16 characters");
            }
            else if (passwCon != passw)
            {
                MessageBox.Show("The passwords are not matched");
            }
            else if (excel.CheckInExcel(UsernameCol, username))
            {
                MessageBox.Show("The username is already use ");
            }
            else
            {
                excel.WriteRangeInExcel(4,vs);
                login.Show();
                this.Hide();
            }
            excel.Save();
            excel.Close();
        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
