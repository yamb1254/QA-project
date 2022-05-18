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
        //A Department constructor who receives a diagnostic object to link the pages to the current user
        public ManualTestBlood(DiagnosisForm diagnosisForm)
        {
            this.Diagnosis = diagnosisForm;
            InitializeComponent();
        }
        //From row 26 to row 85 functions which convert variables from string to double.
        private void TextboxRBC_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxRBC.Text, out double n))
                this.TextboxRBC.Text = "";
            if (this.TextboxRBC.Text != "")
                RBC = Convert.ToDouble(this.TextboxRBC.Text);
           
        }

        private void TextboxUrea_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxUrea.Text, out double n))
                this.TextboxUrea.Text = "";
            else if (this.TextboxUrea.Text != "")
                Urea = Convert.ToDouble(this.TextboxUrea.Text);
        }

        private void TextboxHb_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxHb.Text, out double n))
                this.TextboxHb.Text = "";
            if (this.TextboxHb.Text != "")
                Hb = Convert.ToDouble(this.TextboxHb.Text);
        }

        private void TextboxCrtn_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxCrtn.Text, out double n))
                this.TextboxCrtn.Text = "";
            if (this.TextboxCrtn.Text != "")
                Crtn = Convert.ToDouble(this.TextboxCrtn.Text);
        }

        private void TextBoxIron_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextBoxIron.Text, out double n))
                this.TextBoxIron.Text = "";
            if (this.TextBoxIron.Text != "")
                Iron = Convert.ToDouble(this.TextBoxIron.Text);
        }

        private void TextboxHDL_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxHDL.Text, out double n))
                this.TextboxHDL.Text = "";
            if (this.TextboxHDL.Text != "")
                HDL = Convert.ToDouble(this.TextboxHDL.Text);
        }

        private void TextboxAP_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxAP.Text, out double n))
                this.TextboxAP.Text = "";
            if (this.TextboxAP.Text != "")
                AP = Convert.ToDouble(this.TextboxAP.Text);
        }

        private void TextboxLymph_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxLymph.Text, out double n))
                this.TextboxLymph.Text = "";
            if (this.TextboxLymph.Text != "")
                Lymph = Convert.ToDouble(this.TextboxLymph.Text);
        }

        private void TextBoxNeut_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextBoxNeut.Text, out double n))
                this.TextBoxNeut.Text = "";
            if (this.TextBoxNeut.Text != "")
                Neut = Convert.ToDouble(this.TextBoxNeut.Text);
        }
        private void TextBoxHCT_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextBoxHCT.Text, out double n))
                this.TextBoxHCT.Text = "";
            if (this.TextBoxHCT.Text != "")
                HCT = Convert.ToDouble(this.TextBoxHCT.Text);
        }
        private void TextboxWBC_OnValueChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(this.TextboxWBC.Text, out double n))
                this.TextboxWBC.Text = "";
            if (this.TextboxWBC.Text != "")
                WBC = Convert.ToInt32(this.TextboxWBC.Text);
        }
        //A function that creates string variables and checks that all cells are not empty because everything should be full.
        //If you do not get an error message to fix
        //If so the user / doctor will return to the diagnostic page
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
        //A function that fills the cells automatically when the user / doctor uploads a blood test file
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
        //String array function and return the array.
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
        ////Double array function and return the array.
        public double[] GetVsdouble()
        {
            vsi = new double[] { WBC, Neut, Lymph, RBC, HCT, Urea, Hb, Crtn, Iron, HDL, AP };
            return vsi;
        }
        // Function When a user presses the close button he closes the FORM and returns the user to the diagnostic page
        private void ExitButtonManualTest_Click(object sender, EventArgs e)
        {
            Diagnosis.Show();
            this.Hide();

        }
    }
}

