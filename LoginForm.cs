using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_Projects
{
    public partial class LoginForm : Form
    {
        string username, password;
        DiagnosisForm diagnose;
        RegisterForm register;
        Excel excel;
        const int UsernameCol = 2, PasswordCol = 4;
        string FileName = Path.GetFullPath("LoginInfo.xlsx");
        //Department constructor
        public LoginForm()
        {
            FileName = FileName.Substring(0, FileName.Length - 24);
            FileName = FileName + "LoginInfo.xlsx";
            register = new RegisterForm(this);
            InitializeComponent();
        }
        //A function that activates the FORM of the register when the button is clicked has moved to the registration page
        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register.Show();
            this.Hide();
        }
        //Function When the user presses the close button it closes the FORM and closes the program.
        private void ExitButtonReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //When you enter the correct username and password and click on Login, go to the doctor's diagnostic page.
        //In addition the details of the doctor are kept in excel
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            excel = new Excel(FileName, 1);
            username = TextboxUsername.Text;
            password = TextboxPassword.Text;
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("The fields is empty please fill");
            }
            else if (!excel.CheckInExcel(UsernameCol, username) || !excel.CheckInExcel(PasswordCol, password))
            {
                MessageBox.Show("The Username or Password incorrect !!");
                excel.Close();
            }
            else
            {
                diagnose = new DiagnosisForm(username, this);
                this.Hide();
                excel.Close();
                diagnose.Show();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

