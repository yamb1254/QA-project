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
        string username, password;
        DiagnosisForm diagnose;
        RegisterForm register;
        Excel excel;
        const int UsernameCol = 2 , PasswordCol = 4;
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
            excel = new Excel("C:\\Users\\ישראל\\Documents\\GitHub\\QA-projects\\Excel\\LoginInfo.xlsx", 1);
            username = TextboxUsername.Text;
            password = TextboxPassword.Text;
            if(username == string.Empty || password == string.Empty)
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

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TextboxUsername_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
