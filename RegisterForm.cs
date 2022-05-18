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
        //A builder who gets an object to be linked to the same user page.
        //In addition a variable is created which keeps the details ready to be adapted to that user
        public RegisterForm(LoginForm login)
        {
            FileName = FileName.Substring(0, FileName.Length - 24);
            FileName = FileName + "LoginInfo.xlsx";
            this.login = login;
            InitializeComponent();
        }
        //A function that returns the user to the login page if it already exists in the system
        private void LinkLabelHaveAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login.Show();
            this.Hide();
           
        }
        //Function When the user presses the close button it closes the FORM and closes the program.
        private void ExitButtonReg_Click(object sender, EventArgs e)
        {
           this.Close();
            this.login.Close();
        }
        //A function works when the user clicks on the register button and within it there is a construction of the user and conditions if the details he entered match the requirements of the system
        //If no appropriate message is uploaded and the user will need to fix accordingly
        //If so, the system will save the user's details and return them to the login page
        //In addition the excel file which is used as a database will close
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
            else if(username.Length < 6 || username.Length > 8)
            {
                MessageBox.Show("The username must have between 6-8 characters and max two numbers");
            }
            else if (checkUsername(username) == false)
            {
                MessageBox.Show("Too much digit! maximum 2 digit in Username");
            }
            else if (passw.Length > 10 || passw.Length < 8)
            {
                MessageBox.Show("The password must have between 8-10 characters");
            }
           else if(checkPassword(passw) == false)
            {
                MessageBox.Show("You need a lest one letter, one number and one special char");
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
                excel.WriteRangeInExcel(4, vs);
                login.Show();
                this.Hide();
            }
            excel.Save();
            excel.Close();
        }
        //A help function that checks if the terms of the password are correct so that the user can continue registering
        public Boolean checkPassword(string password)
        {
          
            string specialChar = "!~`@#$%^&*()-=+*/?.><';:][|{}";
            int digit = 0, letters = 0, special = 0;
            foreach(char c in password)
            {
                if (char.IsDigit(c))
                {
                    digit++;
                }
                if (char.IsLetter(c))
                {
                    letters++;
                }
                if (specialChar.Contains(c))
                {
                    special++;
                }
            }
            if(digit == 0 || letters == 0 || special == 0)
            {
                return false;
            }
            return true;
        }
        //A help function that checks if the terms of the username are correct so that the user can continue registering
        public Boolean checkUsername(string username)
        {
            
            int digit = 0;
            foreach(char c in username)
            {
                if (char.IsDigit(c))
                {
                    digit++;
                }
            }
            if(digit > 2)
            {
                return false;
            }
            return true;
        }
    }
}
