using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
        int Age;
        string PaitientForm = System.IO.Path.GetFullPath("PaitientForm.xlsx");
        string path;
        LoginForm login;
        ManualTestBlood manual;
        string userName;
        public DiagnosisForm(string user,LoginForm login)
        {
            PaitientForm = PaitientForm.Substring(0, PaitientForm.Length - 27);
            path = PaitientForm;
            PaitientForm = PaitientForm + "patients\\PaitientForm.xlsx";
            this.login = login;
            this.userName = user;
            manual = new ManualTestBlood(this);
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
            Excel test = new Excel(this.TextboxTestBlood.Text,1);
            manual.Filltextbox(test.ReadExcel(WBC,2), test.ReadExcel(Neut, 2), test.ReadExcel(Lymph, 2), test.ReadExcel(RBC, 2),test.ReadExcel(HCT, 2), test.ReadExcel(Urea, 2), test.ReadExcel(Hb, 2), test.ReadExcel(Crtn, 2), test.ReadExcel(Iron, 2), test.ReadExcel(HDL, 2), test.ReadExcel(AP, 2));
            test.Close();
        }

        private void ButtonManual_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("You want to enter the patient's blood tests manually?", "Manual blood tests", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if(dr == DialogResult.Yes)
            {
                manual.Show();
                this.Hide();

            }

        }

        private void buttonExistingPatient_Click(object sender, EventArgs e)
        {

        }

        private void buttonDiagnose_Click(object sender, EventArgs e)
        {
            string[] Diagnosis = { };
            string[] Recommendation = { };
            double[] vsI = manual.GetVsdouble();
            if (
                (vsI[RBC] < 4.5)
                ||
                (vsI[HCT] < 37 && groupBoxGender.Text == "Male")
                ||
                (vsI[HCT] < 33 && groupBoxGender.Text == "Female")
                ||
                (vsI[Hb]<12 && Age > 17)
                || 
                (vsI[Hb] < 11.5 && Age < 17)
                )
            {
                Diagnosis.Append("Anemia");
                Recommendation.Append("Two 10 mg B12 pills a day for a month");
            }
            





            string[] allInfo = { this.TextBoxFname.Text, this.TextboxLname.Text, this.TextboxID.Text, this.TextboxAge.Text, this.TextboxHeight.Text, this.TextboxWeight.Text, this.TextboxFever.Text, this.TextboxHeartBeat.Text, this.TextboxBloodPre.Text, this.groupBoxGender.Text };
            string[] vs = manual.GetVsString();
            for (int i = 0; i < vs.Length; i++)
                allInfo.Append(vs[i]);
            Excel Paitient = new Excel(PaitientForm,1);
            Paitient.WriteRangeInExcel(21, allInfo);
            for (int i = 0; i < Diagnosis.Length; i++)
            {
                Paitient.WriteInExcel(22, i + 1, Diagnosis[i]);
                bunifuCustomDataGrid1.Rows[i].Cells[0].Value = Diagnosis[i];

            }
            for (int i = 0; i < Recommendation.Length; i++)
            {
                Paitient.WriteInExcel(23, i + 1, Recommendation[i]);
                bunifuCustomDataGrid1.Rows[i].Cells[1].Value = Recommendation[i];
            }
            Paitient.Saveas(path + "patients\\" + TextboxID.Text + ".xlsx");
            Paitient.Close();
        }

        private void TextboxHeartBeat_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextboxAge_OnValueChanged(object sender, EventArgs e)
        {
            Age = Convert.ToInt32(this.TextboxAge.Text);
        }
    }
}
