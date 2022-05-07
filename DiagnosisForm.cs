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
    public partial class DiagnosisForm : Form
    {
        LoginForm login;
        string userName;
        public DiagnosisForm(string user,LoginForm login)
        {
            this.login = login;
            this.userName = user;
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            login.Close();
 
        }

        private void LabelGender_Click(object sender, EventArgs e)
        {
            if(radioButtonM.Checked == true)
            {

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
