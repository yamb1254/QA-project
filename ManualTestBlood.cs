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
    public partial class ManualTestBlood : Form
    {
        
        DiagnosisForm Diagnosis;
        string FileTestBlood = System.IO.Path.GetFullPath("TestBlood.xlsx");
        public ManualTestBlood(DiagnosisForm diagnosisForm)
        {
            this.Diagnosis = diagnosisForm;
             InitializeComponent();
        }

        private void ButtonUplodTestBlood_Click(object sender, EventArgs e)
        {
            string WBC = TextboxWBC.Text;
            string Neut = TextBoxNeut.Text;
            string Lymph = TextboxLymph.Text;
            string RBC = TextboxRBC.Text;
            string HCT = TextBoxHCT.Text;
            string Urea = TextboxUrea.Text;
            string Hb = TextboxHb.Text;
            string Crtn = TextboxCrtn.Text;
            string Iron = TextBoxIron.Text;
            string HDL = TextboxHDL.Text;
            string AP = TextboxAP.Text;

            string[] vs = new string[] { WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP };
            Excel excel = new Excel(FileTestBlood, 1);
            if (WBC == string.Empty || Neut == string.Empty || Lymph == string.Empty || RBC == string.Empty || HCT == string.Empty || Urea == string.Empty || Hb == string.Empty || Crtn == string.Empty || Iron == string.Empty || HDL == string.Empty || AP == string.Empty)
            {
                MessageBox.Show("The fields are empty please fill");
            }
            //else if (passw.Length > 16 || passw.Length < 8)
            //{
            //    MessageBox.Show("The password must have between 8-16 characters");
            //}
            //else if (passwCon != passw)
            //{
            //    MessageBox.Show("The passwords are not matched");
            //}
            //else if (excel.CheckInExcel(UsernameCol, username))
            //{
            //    MessageBox.Show("The username is already use ");
            //}
            else
            {
                excel.WriteRangeInExcel(11, vs);
                Diagnosis.Show();
                this.Hide();
            }
            excel.Save();
            excel.Close();
        }

        private void ExitButtonManualTest_Click(object sender, EventArgs e)
        {
            Diagnosis.Show();
            this.Hide();
            
        }
    }
}

