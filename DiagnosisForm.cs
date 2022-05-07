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
        const int WBC = 1;
        const int Neut = 2;
        const int Lymph = 3;
        const int RBC = 4;
        const int HCT = 5;
        const int Urea = 6;
        const int Hb = 7;
        const int Crtn = 8;
        const int Iron = 9;
        const int HDL = 10;
        const int AP = 11;



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

        private void buttonTestBlood_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TextboxTestBlood.Text = openFileDialog.FileName;
            }
        }
    }
}
