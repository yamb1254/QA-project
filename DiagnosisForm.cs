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
        string Gender;
        bool Eastern, Ethiopian;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
            login.Close();
 
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
            List<string> Diagnosis = new List<string> { };
            List<string> Recommendation = new List<string> { };
            double[] vsI = manual.GetVsdouble();
            if (
                (vsI[RBC] < 4.5)
                ||
                (vsI[HCT] < 37 && Gender == "Male")
                ||
                (vsI[HCT] < 33 && Gender == "Female")
                ||
                (vsI[Hb]<12 && Age > 17)
                || 
                (vsI[Hb] < 11.5 && Age < 17)
                )
            {
                Diagnosis.Add("Anemia");
                Recommendation.Add("Two 10 mg B12 pills a day for a month");
            }
            if(
                (vsI[Urea] > 43)
                ||
               ( vsI[Urea] >46.3 && Eastern)
                ||
               ( vsI[Urea] < 17 )
                ||
               ( vsI[Urea] < 18.7 && Eastern)
                )
            {
                Diagnosis.Add("Diet");
                Recommendation.Add("Schedule an appointment with a nutritionist");
            }
            if (
                (vsI[RBC] < 4.5)
                ||
                (vsI[HCT] < 37 && Gender == "Male")
                ||
                (vsI[HCT] < 33 && Gender == "Female")
                ||
                (vsI[Hb] < 12 && Age > 17)
                ||
                (vsI[Hb] < 11.5 && Age < 17)
                ||
                (vsI[Iron] < 60 && Gender == "Male")
                 ||
                (vsI[Iron] < 48 && Gender == "Female")
                )
            {
                Diagnosis.Add("Bleeding");
                Recommendation.Add("To be rushed to the hospital urgently");
            }

            if (
                (vsI[HDL] < 29 && Gender == "Male")
                ||
                (vsI[HDL] < 34 && Gender == "Female")
                ||
                (vsI[HDL] < 34.8 && Gender == "Male" && Ethiopian)
                ||
                (vsI[HDL] < 40.8 && Gender == "Female" && Ethiopian)
                )
            {
                Diagnosis.Add("Hyperlipidemia (lipids in the blood)");
                Recommendation.Add("Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week");
            }
            if (
                (vsI[Neut] < (vsI[WBC] * 0.28)) 
                ||
                (vsI[Lymph] < (vsI[WBC] * 0.36))
                )
            {
                Diagnosis.Add("Disruption of blood / blood cell formation");
                Recommendation.Add("10 mg pill of B12 a day for a month");
                Recommendation.Add("5 mg pill of folic acid a day for a monthmobil daily for a week");
            }
            if(
                (vsI[Hb] < 12 && Age > 17)
                ||
                (vsI[Hb] < 11.5 && Age < 17)
                )
            {
                Diagnosis.Add("Hematological disorder");
                Recommendation.Add("An injection of a hormone to encourage red blood cell production");
            }
            if (
                (vsI[Iron] > 160 && Gender == "Male")
                ||
                (vsI[Iron] > 128 && Gender == "Female")
                )
            {
                Diagnosis.Add("Iron poisoning");
                Recommendation.Add("To be evacuated to hospital");
            }
            if(
                (vsI[Urea] > 43)
                ||
                (vsI[Urea] > 47.3 && Eastern)
                )
            {
                Diagnosis.Add("Dehydration");
                Recommendation.Add("Complete rest when lying down, returning fluids in drinking");
            }
            if(
                (vsI[WBC] > 11000 && Age > 18)
                ||
                (vsI[WBC] > 15500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC] > 17500 && Age > 0 && Age <= 3)
                ||
                (vsI[Neut] < (vsI[WBC] * 0.28))
                ||
                (vsI[Neut] < (vsI[WBC] * 0.54))
                ||
                (vsI[Lymph] < (vsI[WBC] * 0.52))
                )              
            {
                Diagnosis.Add("Infection");
                Recommendation.Add("Dedicated antibiotics");
            }
            if(
                (vsI[AP] < 60 && Eastern)
                ||
                (vsI[AP] < 30)
                )
            {
                Diagnosis.Add("Vitamin deficiency");
                Recommendation.Add("Referral for a blood test to identify the missing vitamins");
            }
            if(
                (vsI[WBC] < 4500 && Age > 18)
                ||
                (vsI[WBC] < 5500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC] < 6000 && Age > 0 && Age <= 3)
                )
            {
                Diagnosis.Add("Viral disease");
                Recommendation.Add("Rest at home");
            }
            if(
                (vsI[AP] < 120 && Eastern)
                ||
                (vsI[AP] < 90)
                )
            {
                Diagnosis.Add("Diseases of the biliary tract");
                Recommendation.Add("Referral to surgical treatment");
            }
            if(
                (vsI[HDL] < 29 && Gender == "Male")
                ||
                (vsI[HDL] < 34 && Gender == "Female")
                ||
                (vsI[HDL] < 34.8 && Gender == "Male" && Ethiopian)
                ||
                (vsI[HDL] < 40.8 && Gender == "Female" && Ethiopian)
                )
            {
                Diagnosis.Add("Heart disease");
                Recommendation.Add("Schedule an appointment with a nutritionist");
            }
            if(
                (vsI[WBC] > 11000 && Age > 18)
                ||
                (vsI[WBC] > 15500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC] > 17500 && Age > 0 && Age <= 3)
                )
            {
                Diagnosis.Add("Blood disease");
                Recommendation.Add("A combination of cyclophosphamide and corticosteroids");
            }






            List<string> Allinfo = new List<string> { this.TextBoxFname.Text, this.TextboxLname.Text, this.TextboxID.Text, this.TextboxAge.Text, this.TextboxHeight.Text, this.TextboxWeight.Text, this.TextboxFever.Text, this.TextboxHeartBeat.Text, this.TextboxBloodPre.Text, this.Gender };          
            string[] allInfo = { this.TextBoxFname.Text, this.TextboxLname.Text, this.TextboxID.Text, this.TextboxAge.Text, this.TextboxHeight.Text, this.TextboxWeight.Text, this.TextboxFever.Text, this.TextboxHeartBeat.Text, this.TextboxBloodPre.Text,this.Gender};
            string[] vs = manual.GetVsString();
            for (int i = 0; i < vs.Length; i++)
                Allinfo.Add(vs[i]);
            Excel Paitient = new Excel(PaitientForm,1);
            Paitient.WriteRangeInExcelList(21, Allinfo);
            for (int i = 0; i < Diagnosis.Count; i++)
            {
                string[] vs1 = { Diagnosis[i], Recommendation[i] };
                ListViewItem employee = new ListViewItem(vs1);
                ListviewRecommendation.Items.Add(employee);
                Paitient.WriteInExcel(22, i + 2, Diagnosis[i]);
                Paitient.WriteInExcel(23, i + 2, Recommendation[i]);
            }
            Paitient.Saveas(path + "patients\\" + TextboxID.Text + ".xlsx");
            Paitient.Close();
        }

        private string radioButtonM_CheckedChanged()
        {
            throw new NotImplementedException();
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

        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void ListviewRecommendation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxQ2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonYQ2_CheckedChanged(object sender, EventArgs e)
        {
            Eastern = true;
        }
        private void radioButtonNQ2_CheckedChanged(object sender, EventArgs e)
        {
            Eastern = false;
        }

        private void radioButtonYQ5_CheckedChanged(object sender, EventArgs e)
        {
            Ethiopian = true;
        }

        private void radioButtonNQ5_CheckedChanged(object sender, EventArgs e)
        {
            Ethiopian = false;
        }

       
    }
}
