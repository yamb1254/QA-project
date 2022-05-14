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
        string[] vs;
        double[] vsi;
        double WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP;

        private void TextboxRBC_OnValueChanged(object sender, EventArgs e)
        {
            RBC = Convert.ToDouble(this.TextboxRBC.Text);
        }

        private void TextboxUrea_OnValueChanged(object sender, EventArgs e)
        {
            Urea = Convert.ToDouble(this.TextboxUrea.Text);
        }

        private void TextboxHb_OnValueChanged(object sender, EventArgs e)
        {
            Hb = Convert.ToDouble(this.TextboxHb.Text);
        }

        private void TextboxCrtn_OnValueChanged(object sender, EventArgs e)
        {
            Crtn = Convert.ToDouble(this.TextboxCrtn.Text);
        }

        private void TextBoxIron_OnValueChanged(object sender, EventArgs e)
        {
            Iron = Convert.ToDouble(this.TextBoxIron.Text);
        }

        private void TextboxHDL_OnValueChanged(object sender, EventArgs e)
        {
            HDL = Convert.ToDouble(this.TextboxHDL.Text);
        }

        private void TextboxAP_OnValueChanged(object sender, EventArgs e)
        {
            AP = Convert.ToDouble(this.TextboxAP.Text);
        }

        private void TextboxLymph_OnValueChanged(object sender, EventArgs e)
        {
            Lymph = Convert.ToDouble(this.TextboxLymph.Text);
        }

        private void TextBoxNeut_OnValueChanged(object sender, EventArgs e)
        {
            Neut = Convert.ToDouble(this.TextBoxNeut.Text);
        }

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
            if (WBC == string.Empty || Neut == string.Empty || Lymph == string.Empty || RBC == string.Empty || HCT == string.Empty || Urea == string.Empty || Hb == string.Empty || Crtn == string.Empty || Iron == string.Empty || HDL == string.Empty || AP == string.Empty)
            {
                MessageBox.Show("The fields are empty please fill");
            }
            else
            {
                Diagnosis.Show();
                this.Hide();
            }
        }

        private void ExitButtonManualTest_Click(object sender, EventArgs e)
        {
            Diagnosis.Show();
            this.Hide();
            
        }

        private void TextboxWBC_OnValueChanged(object sender, EventArgs e)
        {
            WBC = Convert.ToInt32(this.TextboxWBC.Text);
        }
        public void Filltextbox(string WBC, string Neut ,string Lymph ,string RBC ,string HCT ,string Urea,string Hb ,string Crtn,string Iron,string HDL,string AP)
        {
            this.TextboxWBC.Text = WBC;
            this.TextBoxNeut.Text = Neut;
            this.TextboxLymph.Text = Lymph;
            this.TextboxRBC.Text = RBC;
            this.TextBoxHCT.Text = HCT;
            this.TextboxUrea.Text = Urea;
            this.TextboxHb.Text = Hb;  
            this.TextboxCrtn.Text = Crtn;   
            this.TextBoxIron.Text = Iron;   
            this.TextboxHDL.Text = HDL; 
            this.TextboxAP.Text = AP;  
        }
        public string[] GetVsString()
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
            vs = new string[] { WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP };
            return vs;
        }
        public double[] GetVsdouble()
        {
            vsi = new double[] { WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP };
            return vsi;
        }

        private void TextBoxHCT_OnValueChanged(object sender, EventArgs e)
        {
            HCT = Convert.ToDouble(this.TextBoxHCT.Text);
        }
    }
}

