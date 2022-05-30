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
        string path,existPath;
        LoginForm login;
        ManualTestBlood manual;
        Excel Paitient;
        string userName;
        string Gender;
        bool Eastern, Ethiopian,Smokers, Pregnant, Diarrhea;
        //A department builder who receives a login object and uses it to know which doctor to refer to each use of the software. In addition, a database is created which keeps the patient's details and the doctor's diagnosis.
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
        //A function that creates a dialogue with the user and opens a window for him so that he can raise the patient's blood tests.
        //In addition, it keeps the results in the cells that we have defined.
        private void buttonTestBlood_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory= path + "patients\\";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TextboxTestBlood.Text = openFileDialog.FileName;
            }
            try
            {
                Excel test = new Excel(this.TextboxTestBlood.Text, 1);
                manual.Filltextbox(test.ReadExcel(WBC, 2), test.ReadExcel(Neut, 2), test.ReadExcel(Lymph, 2), test.ReadExcel(RBC, 2), test.ReadExcel(HCT, 2), test.ReadExcel(Urea, 2), test.ReadExcel(Hb, 2), test.ReadExcel(Crtn, 2), test.ReadExcel(Iron, 2), test.ReadExcel(HDL, 2), test.ReadExcel(AP, 2));
                test.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("You dont choose a Test Blood file");
            }
        }
        //A function that asks the user if he wants to enter blood tests manually in case the user gets wet he will be taken to the details page.
        //If not the message will be closed
        private void ButtonManual_Click(object sender, EventArgs e)
        {
           DialogResult dr = MessageBox.Show("You want to enter the patient's blood tests manually?", "Manual blood tests", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                manual.Show();
                this.Hide();
            }
        }

        private void buttonDiagnose_Click(object sender, EventArgs e)
        {
            ListviewRecommendation.Items.Clear();
            List<string> Diagnosis = new List<string> { };
            List<string> Recommendation = new List<string> { };
            double[] vsI = manual.GetVsdouble();
            if(TextBoxFname.Text == "" || TextboxLname.Text == "" || TextboxID.Text == "" || TextboxAge.Text == "" || TextboxHeight.Text == "" || TextboxWeight.Text == "" || TextboxFever.Text == "" || TextboxHeartBeat.Text == "" || TextboxBloodPre.Text == "" || Gender == null || Diarrhea == null || Eastern == null || Pregnant == null || Smokers == null || Ethiopian == null)
            {
                MessageBox.Show("Please fill in all the fields");
                return;
            }
            if(TextboxID.Text.Length != 9) 
            {
                MessageBox.Show("Please insert correct ID");
                return;
            }
            if (
                (vsI[RBC-1] < 4.5)
                ||
                (vsI[HCT-1] < 37 && Gender == "Male")
                ||
                (vsI[HCT-1] < 33 && Gender == "Female")
                ||
                (vsI[Hb-1]<12 && Age > 17)
                || 
                (vsI[Hb-1] < 11.5 && Age < 17)
                )
            {
                Diagnosis.Add("Anemia");
                Recommendation.Add("Two 10 mg B12 pills a day for a month");
            }
            if(
                (vsI[Urea-1] > 43)
                ||
               ( vsI[Urea-1] >46.3 && Eastern)
                ||
               ( vsI[Urea-1] < 17 )
                ||
               ( vsI[Urea-1] < 18.7 && Eastern)
                )
            {
                Diagnosis.Add("Diet");
                Recommendation.Add("Schedule an appointment with a nutritionist");
            }
            if (
                (vsI[RBC-1] < 4.5)
                ||
                (vsI[HCT-1] < 37 && Gender == "Male")
                ||
                (vsI[HCT-1] < 33 && Gender == "Female")
                ||
                (vsI[Hb-1] < 12 && Age > 17)
                ||
                (vsI[Hb-1] < 11.5 && Age <= 17)
                ||
                (vsI[Iron-1] < 60 && Gender == "Male")
                 ||
                (vsI[Iron-1] < 48 && Gender == "Female")
                )
            {
                Diagnosis.Add("Bleeding");
                Recommendation.Add("To be rushed to the hospital urgently");
            }

            if (
                (vsI[HDL-1] < 29 && Gender == "Male")
                ||
                (vsI[HDL-1] < 34 && Gender == "Female")
                ||
                (vsI[HDL-1] < 34.8 && Gender == "Male" && Ethiopian)
                ||
                (vsI[HDL-1] < 40.8 && Gender == "Female" && Ethiopian)
                )
            {
                Diagnosis.Add("Hyperlipidemia (lipids in the blood)");
                Recommendation.Add("Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week");
            }
            if (
                (vsI[Neut-1] < (vsI[WBC] * 0.28)) 
                ||
                (vsI[Lymph-1] < (vsI[WBC] * 0.36))
                )
            {
                Diagnosis.Add("Disruption of blood / blood cell formation");
                Recommendation.Add("10 mg pill of B12 a day for a month");
                Recommendation.Add("5 mg pill of folic acid a day for a monthmobil daily for a week");
            }
            if(
                (vsI[Hb-1] < 12 && Age > 17)
                ||
                (vsI[Hb-1] < 11.5 && Age < 17)
                )
            {
                Diagnosis.Add("Hematological disorder");
                Recommendation.Add("An injection of a hormone to encourage red blood cell production");
            }
            if (
                (vsI[Iron-1] > 160 && Gender == "Male")
                ||
                (vsI[Iron] > 128 && Gender == "Female")
                )
            {
                Diagnosis.Add("Iron poisoning");
                Recommendation.Add("To be evacuated to hospital");
            }
            if(
                (vsI[Urea-1] > 43)
                ||
                (vsI[Urea-1] > 47.3 && Eastern)
                )
            {
                Diagnosis.Add("Dehydration");
                Recommendation.Add("Complete rest when lying down, returning fluids in drinking");
            }
            if (
                (vsI[WBC-1] > 11000 && Age > 18)
                ||
                (vsI[WBC-1] > 15500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC-1] > 17500 && Age > 0 && Age <= 3)
                ||
                (vsI[Neut-1] < (vsI[WBC] * 0.28))
                ||
                (vsI[Neut-1] > (vsI[WBC] * 0.54))
                ||
                (vsI[Lymph-1] < (vsI[WBC] * 0.52))
                )              
            {
                Diagnosis.Add("Infection");
                Recommendation.Add("Dedicated antibiotics");
            }
            if (
                (vsI[AP-1] < 60 && Eastern)
                ||
                (vsI[AP-1] < 30)
              )
            {
                Diagnosis.Add("Vitamin deficiency");
                Recommendation.Add("Referral for a blood test to identify the missing vitamins");
            }
            if(
                (vsI[WBC-1] < 4500 && Age > 18)
                ||
                (vsI[WBC-1] < 5500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC-1] < 6000 && Age > 0 && Age <= 3)
                )
            {
                Diagnosis.Add("Viral disease");
                Recommendation.Add("Rest at home");
            }
            if(
                (vsI[AP-1] > 120 && Eastern && (!Pregnant))
                ||
                (vsI[AP-1] > 90 && (!Pregnant))
                )
            {
                Diagnosis.Add("Diseases of the biliary tract");
                Recommendation.Add("Referral to surgical treatment");
            }
            if(
                (vsI[HDL-1] < 29 && Gender == "Male")
                ||
                (vsI[HDL-1] < 34 && Gender == "Female")
                ||
                (vsI[HDL-1] < 34.8 && Gender == "Male" && Ethiopian)
                ||
                (vsI[HDL-1] < 40.8 && Gender == "Female" && Ethiopian)
                )
            {
                Diagnosis.Add("Heart disease");
                Recommendation.Add("Schedule an appointment with a nutritionist");
            }
            if(
                (vsI[WBC-1] > 11000 && Age >= 18)
                ||
                (vsI[WBC-1] > 15500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC-1] > 17500 && Age > 0 && Age <= 3)
                )
            {
                Diagnosis.Add("Blood disease");
                Recommendation.Add("A combination of cyclophosphamide and corticosteroids");
            }
            if(
                (vsI[Urea-1] < 17)
                ||
                (vsI[Urea-1] < 18.7 && Eastern)
                ||
                (vsI[AP-1] > 120 && Eastern && (!Pregnant))
                ||
                (vsI[AP-1] > 90 && (!Pregnant))
                )
            {
                Diagnosis.Add("Liver disease");
                Recommendation.Add("Referral to a specific diagnosis for the purpose of determining treatment");
            }
            if(
                (vsI[Urea-1] > 43)
                ||
                (vsI[Urea-1] > 47.3 && Eastern)
                ||
                (vsI[Crtn-1]>0.5 && Age > 0 && Age <= 2 )
                ||
                (vsI[Crtn-1] > 1 && Age >= 3 && Age <= 17)
                ||
                (vsI[Crtn-1] > 1 && Age >= 18 && Age <= 59)
                ||
                (vsI[Crtn-1] > 1.2 && Age >= 60)
                )
            {
                Diagnosis.Add("Kidney disease");
                Recommendation.Add("Balancing blood sugar levels");
            }
            if(
                (vsI[Hb-1] < 12 && Age > 17)
                ||
                (vsI[Hb-1] < 11.5 && Age <= 17)
                )
            {
                Diagnosis.Add("Iron deficiency");
                Recommendation.Add("Two 10 mg B12 pills a day for a month");
            }
            if(
                (vsI[Crtn-1] > 0.5 && Age > 0 && Age <= 2)
                ||
                (vsI[Crtn-1] > 1 && Age >= 3 && Age <= 17)
                ||
                (vsI[Crtn-1] > 1 && Age >= 18 && Age <= 59)
                ||
                (vsI[Crtn-1] > 1.2 && Age >= 60)
                )
            {
                Diagnosis.Add("Muscle diseases");
                Recommendation.Add("Two 5 mg pills of Altman c3 turmeric a day for a month");
            }
            if(Smokers)
            {
                Diagnosis.Add("Smokers");
                Recommendation.Add("Stop smoking");
            }
            if(
               (Smokers)
               ||
               (vsI[RBC-1] > 6)
                )
            {
                Diagnosis.Add("Lung disease");
                Recommendation.Add("Stop smoking / Refer to an X-ray of the lungs");
            }
            if(
                (vsI[AP - 1] > 120 && Eastern && (!Pregnant))
                ||
                (vsI[AP - 1] > 90 && (!Pregnant))
                )
            {
                Diagnosis.Add("Thyroid overactivity");
                Recommendation.Add("Propylthiouracil to reduce thyroid activity");
            }
            if(
                (vsI[HDL - 1] < 29 && Gender == "Male")
                ||
                (vsI[HDL - 1] < 34 && Gender == "Female")
                ||
                (vsI[HDL - 1] < 34.8 && Gender == "Male" && Ethiopian)
                ||
                (vsI[HDL - 1] < 40.8 && Gender == "Female" && Ethiopian)
                )
            {
                Diagnosis.Add("Adult diabetes");
                Recommendation.Add("Insulin adjustment for the patient");
            }
            if(
                (vsI[WBC - 1] > 11000 && Age >= 18)
                ||
                (vsI[WBC - 1] > 15500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC - 1] > 17500 && Age > 0 && Age <= 3)
                ||
                (vsI[WBC - 1] < 4500 && Age > 18)
                ||
                (vsI[WBC - 1] < 5500 && Age <= 17 && Age >= 4)
                ||
                (vsI[WBC - 1] < 6000 && Age > 0 && Age <= 3)
                ||
                (vsI[Neut - 1] < (vsI[WBC] * 0.28))
                ||
                (vsI[Neut - 1] > (vsI[WBC] * 0.54))
                )
            {
                Diagnosis.Add("Cancer");
                Recommendation.Add("Antarctinib - E");
            }
            if(
                (vsI[Crtn - 1] > 0.5 && Age > 0 && Age <= 2)
                ||
                (vsI[Crtn - 1] > 1 && Age >= 3 && Age <= 17)
                ||
                (vsI[Crtn - 1] > 1 && Age >= 18 && Age <= 59)
                ||
                (vsI[Crtn - 1] > 1.2 && Age >= 60)
                )
            {
                Diagnosis.Add("Increased meat intake");
                Recommendation.Add("Coordinate an appointment with a nutritionist");
            }
            if(
                (vsI[AP - 1] > 120 && Eastern && (!Pregnant))
                ||
                (vsI[AP - 1] > 90 && (!Pregnant))
                )
            {
                Diagnosis.Add("Use of various medications");
                Recommendation.Add("Referral to a family doctor for a match between medications");
            }
            if(
                (vsI[Urea - 1] < 17)
                ||
                (vsI[Urea - 1] < 18.7 && Eastern)
                )
            {
                Diagnosis.Add("Malnutrition");
                Recommendation.Add("Coordinate an appointment with a nutritionist");
            }
            if (Pregnant)
            {
                Diagnosis.Add("Pregnant");
                Recommendation.Add("Please consult gynecologist about AP values");
            }

            List<string> Allinfo = new List<string> { this.TextBoxFname.Text, this.TextboxLname.Text, this.TextboxID.Text, this.TextboxAge.Text, this.TextboxHeight.Text, this.TextboxWeight.Text, this.TextboxFever.Text, this.TextboxHeartBeat.Text, this.TextboxBloodPre.Text, this.Gender };          
            string[] allInfo = { this.TextBoxFname.Text, this.TextboxLname.Text, this.TextboxID.Text, this.TextboxAge.Text, this.TextboxHeight.Text, this.TextboxWeight.Text, this.TextboxFever.Text, this.TextboxHeartBeat.Text, this.TextboxBloodPre.Text,this.Gender};
            string[] vs = manual.GetVsString();
            for (int i = 0; i < vs.Length; i++)
                Allinfo.Add(vs[i]);
            if (Paitient != null)
            {
                if (Paitient.getIsOpen())
                {
                    Paitient.WriteRangeInExcelList(21, Allinfo);
                    for (int i = 0; i < Diagnosis.Count; i++)
                    {
                        string[] vs1 = { Diagnosis[i], Recommendation[i] };
                        ListViewItem employee = new ListViewItem(vs1);
                        ListviewRecommendation.Items.Add(employee);
                        Paitient.WriteInExcel(22, i + 2, Diagnosis[i]);
                        Paitient.WriteInExcel(23, i + 2, Recommendation[i]);
                    }
                    Paitient.Save();
                }
            }
            else
            {
                try
                {
                    Paitient = new Excel(PaitientForm, 1);
                    Paitient.WriteRangeInExcelList(21, Allinfo);
                    for (int i = 0; i < Diagnosis.Count; i++)
                    {
                        string[] vs1 = { Diagnosis[i], Recommendation[i] };
                        ListViewItem employee = new ListViewItem(vs1);
                        ListviewRecommendation.Items.Add(employee);
                        Paitient.WriteInExcel(22, i + 2, Diagnosis[i]);
                        Paitient.WriteInExcel(23, i + 2, Recommendation[i]);
                    }
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel|*.xlsx";
                    saveFileDialog.Title = "Save the Form in Excel";
                    saveFileDialog.FileName = TextboxID.Text + ".xlsx";
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        existPath = saveFileDialog.FileName;
                    }
                    Paitient.Saveas(existPath);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error , the Excel PaitientForm open plese close it");
                }
            }
            Paitient.Close();

        }

        private string radioButtonM_CheckedChanged()
        {
            throw new NotImplementedException();
        }

        //A function which converts a string of age to int
        private void TextboxAge_OnValueChanged(object sender, EventArgs e)
        {
            
            if (!double.TryParse(this.TextboxAge.Text, out double n))
            {
                this.TextboxAge.Text = "";
                if (this.TextboxAge.Text != "")
                {
                    Age = Convert.ToInt32(this.TextboxAge.Text);
                }
            }
        }

        //From line 425 to line 483 Functions that return true or false according to what the user clicks on the radiobutton in the diagnostic questions
        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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

        private void radioButtonYQ4_CheckedChanged(object sender, EventArgs e)
        {
            Smokers = true;
        }

        private void radioButtonYQ1_CheckedChanged(object sender, EventArgs e)
        {
            Diarrhea = true;
        }

        private void radioButtonNQ1_CheckedChanged(object sender, EventArgs e)
        {
            Diarrhea = false;
        }

        private void radioButtonYQ3_CheckedChanged(object sender, EventArgs e)
        {
            Pregnant = true;
        }

        private void TextboxID_OnValueChanged(object sender, EventArgs e)
        {

            if (!double.TryParse(this.TextboxID.Text, out double n))
            {
                this.TextboxID.Text = "";
                if (this.TextboxID.Text != "")
                {

                    this.TextboxID.Text = "";
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonNQ3_CheckedChanged(object sender, EventArgs e)
        {
            Pregnant = false;
        }

        private void radioButtonNQ4_CheckedChanged(object sender, EventArgs e)
        {
            Smokers = false;
        }

        private void buttonExistingPatient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                existPath=openFileDialog.FileName;
            }
            try
            {
                Paitient = new Excel(existPath, 1);
                manual.Filltextbox(Paitient.ReadExcel(WBC + 10, 2), Paitient.ReadExcel(Neut + 10, 2), Paitient.ReadExcel(Lymph + 10, 2), Paitient.ReadExcel(RBC + 10, 2), Paitient.ReadExcel(HCT + 10, 2), Paitient.ReadExcel(Urea + 10, 2), Paitient.ReadExcel(Hb + 10, 2), Paitient.ReadExcel(Crtn + 10, 2), Paitient.ReadExcel(Iron + 10, 2), Paitient.ReadExcel(HDL + 10, 2), Paitient.ReadExcel(AP + 10, 2));
                TextBoxFname.Text = Paitient.ReadExcel(1, 2);
                TextboxLname.Text = Paitient.ReadExcel(2, 2);
                TextboxID.Text = Paitient.ReadExcel(3, 2);
                TextboxAge.Text = Paitient.ReadExcel(4, 2);
                TextboxHeight.Text = Paitient.ReadExcel(5, 2);
                TextboxWeight.Text = Paitient.ReadExcel(6, 2);
                TextboxFever.Text = Paitient.ReadExcel(7, 2);
                TextboxHeartBeat.Text = Paitient.ReadExcel(8, 2);
                TextboxBloodPre.Text = Paitient.ReadExcel(9, 2);
                ListviewRecommendation.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("You dont choose a patient");

            }
        }

        //Function When the user presses the close button it closes the FORM and closes the program.
        private void ExitButton_Click(object sender, EventArgs e)
        {
          
            
            Close();
            try
            {
                if (Paitient.getIsOpen())
                    Paitient.Close();
            }
            catch(NullReferenceException)
            {

            }
            login.Close();

        }

    }
}
