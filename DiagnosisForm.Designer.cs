﻿
namespace QA_Projects
{
    partial class DiagnosisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFirst = new System.Windows.Forms.Label();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelGender = new System.Windows.Forms.Label();
            this.LabelBlood = new System.Windows.Forms.Label();
            this.LabelHeart = new System.Windows.Forms.Label();
            this.LabelFever = new System.Windows.Forms.Label();
            this.LabelLastN = new System.Windows.Forms.Label();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.TextboxBloodPre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxFname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxLname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxHeight = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxWeight = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxFever = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxHeartBeat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonTestBlood = new System.Windows.Forms.Button();
            this.LabelTestBlood = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonYQ1 = new System.Windows.Forms.RadioButton();
            this.radioButtonNQ1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDiagnose = new System.Windows.Forms.Button();
            this.ExitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxQ1 = new System.Windows.Forms.GroupBox();
            this.groupBoxQ2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNQ2 = new System.Windows.Forms.RadioButton();
            this.radioButtonYQ2 = new System.Windows.Forms.RadioButton();
            this.groupBoxQ5 = new System.Windows.Forms.GroupBox();
            this.radioButtonNQ5 = new System.Windows.Forms.RadioButton();
            this.radioButtonYQ5 = new System.Windows.Forms.RadioButton();
            this.groupBoxQ4 = new System.Windows.Forms.GroupBox();
            this.radioButtonNQ4 = new System.Windows.Forms.RadioButton();
            this.radioButtonYQ4 = new System.Windows.Forms.RadioButton();
            this.groupBoxQ3 = new System.Windows.Forms.GroupBox();
            this.radioButtonNQ3 = new System.Windows.Forms.RadioButton();
            this.radioButtonYQ3 = new System.Windows.Forms.RadioButton();
            this.TextboxTestBlood = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonManual = new System.Windows.Forms.Button();
            this.buttonExistingPatient = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recommendation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.groupBoxGender.SuspendLayout();
            this.groupBoxQ1.SuspendLayout();
            this.groupBoxQ2.SuspendLayout();
            this.groupBoxQ5.SuspendLayout();
            this.groupBoxQ4.SuspendLayout();
            this.groupBoxQ3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient details:";
            // 
            // LabelFirst
            // 
            this.LabelFirst.AutoSize = true;
            this.LabelFirst.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFirst.Location = new System.Drawing.Point(10, 73);
            this.LabelFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFirst.Name = "LabelFirst";
            this.LabelFirst.Size = new System.Drawing.Size(83, 17);
            this.LabelFirst.TabIndex = 4;
            this.LabelFirst.Text = "First Name:";
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWeight.Location = new System.Drawing.Point(10, 236);
            this.LabelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(59, 17);
            this.LabelWeight.TabIndex = 5;
            this.LabelWeight.Text = "Weight:";
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeight.Location = new System.Drawing.Point(10, 203);
            this.LabelHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(56, 17);
            this.LabelHeight.TabIndex = 6;
            this.LabelHeight.Text = "Height:";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAge.Location = new System.Drawing.Point(10, 171);
            this.LabelAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(40, 17);
            this.LabelAge.TabIndex = 7;
            this.LabelAge.Text = "Age:";
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelId.Location = new System.Drawing.Point(10, 138);
            this.LabelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(26, 17);
            this.LabelId.TabIndex = 8;
            this.LabelId.Text = "ID:";
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGender.Location = new System.Drawing.Point(10, 366);
            this.LabelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(63, 17);
            this.LabelGender.TabIndex = 9;
            this.LabelGender.Text = "Gender:";
            this.LabelGender.Click += new System.EventHandler(this.LabelGender_Click);
            // 
            // LabelBlood
            // 
            this.LabelBlood.AutoSize = true;
            this.LabelBlood.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBlood.Location = new System.Drawing.Point(10, 333);
            this.LabelBlood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelBlood.Name = "LabelBlood";
            this.LabelBlood.Size = new System.Drawing.Size(109, 17);
            this.LabelBlood.TabIndex = 10;
            this.LabelBlood.Text = "Blood Pressure:";
            // 
            // LabelHeart
            // 
            this.LabelHeart.AutoSize = true;
            this.LabelHeart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeart.Location = new System.Drawing.Point(10, 301);
            this.LabelHeart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHeart.Name = "LabelHeart";
            this.LabelHeart.Size = new System.Drawing.Size(78, 17);
            this.LabelHeart.TabIndex = 11;
            this.LabelHeart.Text = "HeartBeat:";
            // 
            // LabelFever
            // 
            this.LabelFever.AutoSize = true;
            this.LabelFever.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFever.Location = new System.Drawing.Point(10, 268);
            this.LabelFever.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelFever.Name = "LabelFever";
            this.LabelFever.Size = new System.Drawing.Size(48, 17);
            this.LabelFever.TabIndex = 12;
            this.LabelFever.Text = "Fever:";
            // 
            // LabelLastN
            // 
            this.LabelLastN.AutoSize = true;
            this.LabelLastN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastN.Location = new System.Drawing.Point(10, 106);
            this.LabelLastN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLastN.Name = "LabelLastN";
            this.LabelLastN.Size = new System.Drawing.Size(83, 17);
            this.LabelLastN.TabIndex = 13;
            this.LabelLastN.Text = "Last Name:";
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(9, 6);
            this.radioButtonM.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(48, 17);
            this.radioButtonM.TabIndex = 24;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Male";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(74, 6);
            this.radioButtonF.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(59, 17);
            this.radioButtonF.TabIndex = 25;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Female";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // TextboxBloodPre
            // 
            this.TextboxBloodPre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxBloodPre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxBloodPre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxBloodPre.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxBloodPre.HintText = "";
            this.TextboxBloodPre.isPassword = false;
            this.TextboxBloodPre.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxBloodPre.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxBloodPre.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxBloodPre.LineThickness = 3;
            this.TextboxBloodPre.Location = new System.Drawing.Point(115, 322);
            this.TextboxBloodPre.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxBloodPre.Name = "TextboxBloodPre";
            this.TextboxBloodPre.Size = new System.Drawing.Size(152, 27);
            this.TextboxBloodPre.TabIndex = 38;
            this.TextboxBloodPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxID
            // 
            this.TextboxID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxID.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxID.HintText = "";
            this.TextboxID.isPassword = false;
            this.TextboxID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxID.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxID.LineThickness = 3;
            this.TextboxID.Location = new System.Drawing.Point(115, 127);
            this.TextboxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxID.Name = "TextboxID";
            this.TextboxID.Size = new System.Drawing.Size(152, 27);
            this.TextboxID.TabIndex = 32;
            this.TextboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBoxFname.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxFname.HintText = "";
            this.TextBoxFname.isPassword = false;
            this.TextBoxFname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextBoxFname.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBoxFname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextBoxFname.LineThickness = 3;
            this.TextBoxFname.Location = new System.Drawing.Point(115, 62);
            this.TextBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(152, 27);
            this.TextBoxFname.TabIndex = 30;
            this.TextBoxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxLname
            // 
            this.TextboxLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxLname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxLname.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxLname.HintText = "";
            this.TextboxLname.isPassword = false;
            this.TextboxLname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxLname.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxLname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxLname.LineThickness = 3;
            this.TextboxLname.Location = new System.Drawing.Point(115, 93);
            this.TextboxLname.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxLname.Name = "TextboxLname";
            this.TextboxLname.Size = new System.Drawing.Size(152, 27);
            this.TextboxLname.TabIndex = 31;
            this.TextboxLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxAge
            // 
            this.TextboxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxAge.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxAge.HintText = "";
            this.TextboxAge.isPassword = false;
            this.TextboxAge.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxAge.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxAge.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxAge.LineThickness = 3;
            this.TextboxAge.Location = new System.Drawing.Point(115, 159);
            this.TextboxAge.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxAge.Name = "TextboxAge";
            this.TextboxAge.Size = new System.Drawing.Size(152, 27);
            this.TextboxAge.TabIndex = 33;
            this.TextboxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxAge.OnValueChanged += new System.EventHandler(this.TextboxAge_OnValueChanged);
            // 
            // TextboxHeight
            // 
            this.TextboxHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxHeight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxHeight.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxHeight.HintText = "";
            this.TextboxHeight.isPassword = false;
            this.TextboxHeight.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxHeight.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxHeight.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxHeight.LineThickness = 3;
            this.TextboxHeight.Location = new System.Drawing.Point(115, 192);
            this.TextboxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxHeight.Name = "TextboxHeight";
            this.TextboxHeight.Size = new System.Drawing.Size(152, 27);
            this.TextboxHeight.TabIndex = 34;
            this.TextboxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxWeight
            // 
            this.TextboxWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxWeight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxWeight.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxWeight.HintText = "";
            this.TextboxWeight.isPassword = false;
            this.TextboxWeight.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxWeight.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxWeight.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxWeight.LineThickness = 3;
            this.TextboxWeight.Location = new System.Drawing.Point(115, 224);
            this.TextboxWeight.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxWeight.Name = "TextboxWeight";
            this.TextboxWeight.Size = new System.Drawing.Size(152, 27);
            this.TextboxWeight.TabIndex = 35;
            this.TextboxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxFever
            // 
            this.TextboxFever.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxFever.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxFever.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxFever.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxFever.HintText = "";
            this.TextboxFever.isPassword = false;
            this.TextboxFever.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxFever.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxFever.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxFever.LineThickness = 3;
            this.TextboxFever.Location = new System.Drawing.Point(115, 257);
            this.TextboxFever.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxFever.Name = "TextboxFever";
            this.TextboxFever.Size = new System.Drawing.Size(152, 27);
            this.TextboxFever.TabIndex = 36;
            this.TextboxFever.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextboxHeartBeat
            // 
            this.TextboxHeartBeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxHeartBeat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxHeartBeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxHeartBeat.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxHeartBeat.HintText = "";
            this.TextboxHeartBeat.isPassword = false;
            this.TextboxHeartBeat.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxHeartBeat.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxHeartBeat.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxHeartBeat.LineThickness = 3;
            this.TextboxHeartBeat.Location = new System.Drawing.Point(115, 289);
            this.TextboxHeartBeat.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxHeartBeat.Name = "TextboxHeartBeat";
            this.TextboxHeartBeat.Size = new System.Drawing.Size(152, 27);
            this.TextboxHeartBeat.TabIndex = 37;
            this.TextboxHeartBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxHeartBeat.OnValueChanged += new System.EventHandler(this.TextboxHeartBeat_OnValueChanged);
            // 
            // buttonTestBlood
            // 
            this.buttonTestBlood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.buttonTestBlood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTestBlood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTestBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestBlood.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestBlood.Location = new System.Drawing.Point(211, 394);
            this.buttonTestBlood.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTestBlood.Name = "buttonTestBlood";
            this.buttonTestBlood.Size = new System.Drawing.Size(90, 31);
            this.buttonTestBlood.TabIndex = 40;
            this.buttonTestBlood.Text = "Upload";
            this.buttonTestBlood.UseVisualStyleBackColor = false;
            this.buttonTestBlood.Click += new System.EventHandler(this.buttonTestBlood_Click);
            // 
            // LabelTestBlood
            // 
            this.LabelTestBlood.AutoSize = true;
            this.LabelTestBlood.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestBlood.Location = new System.Drawing.Point(9, 398);
            this.LabelTestBlood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTestBlood.Name = "LabelTestBlood";
            this.LabelTestBlood.Size = new System.Drawing.Size(80, 17);
            this.LabelTestBlood.TabIndex = 37;
            this.LabelTestBlood.Text = "Test Blood:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Do you smoke?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(319, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Patient Questions:";
            // 
            // radioButtonYQ1
            // 
            this.radioButtonYQ1.AutoSize = true;
            this.radioButtonYQ1.Location = new System.Drawing.Point(5, 13);
            this.radioButtonYQ1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYQ1.Name = "radioButtonYQ1";
            this.radioButtonYQ1.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYQ1.TabIndex = 41;
            this.radioButtonYQ1.TabStop = true;
            this.radioButtonYQ1.Text = "Yes";
            this.radioButtonYQ1.UseVisualStyleBackColor = true;
            // 
            // radioButtonNQ1
            // 
            this.radioButtonNQ1.AutoSize = true;
            this.radioButtonNQ1.Location = new System.Drawing.Point(50, 13);
            this.radioButtonNQ1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNQ1.Name = "radioButtonNQ1";
            this.radioButtonNQ1.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNQ1.TabIndex = 42;
            this.radioButtonNQ1.TabStop = true;
            this.radioButtonNQ1.Text = "No";
            this.radioButtonNQ1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Do you come from the Eastern testimony?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Are you from Ethiopia?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Are you having diarrhea / vomiting in the last few days?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Are you pregnant?(For male press no)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.label8.Location = new System.Drawing.Point(319, 397);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "**Please fill in all the fields";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonDiagnose
            // 
            this.buttonDiagnose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.buttonDiagnose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDiagnose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnose.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiagnose.Location = new System.Drawing.Point(322, 436);
            this.buttonDiagnose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiagnose.Name = "buttonDiagnose";
            this.buttonDiagnose.Size = new System.Drawing.Size(90, 31);
            this.buttonDiagnose.TabIndex = 41;
            this.buttonDiagnose.Text = "Diagnose";
            this.buttonDiagnose.UseVisualStyleBackColor = false;
            this.buttonDiagnose.Click += new System.EventHandler(this.buttonDiagnose_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageActive = ((System.Drawing.Image)(resources.GetObject("ExitButton.ImageActive")));
            this.ExitButton.Location = new System.Drawing.Point(889, 10);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(49, 26);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 57;
            this.ExitButton.TabStop = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonF);
            this.groupBoxGender.Controls.Add(this.radioButtonM);
            this.groupBoxGender.Location = new System.Drawing.Point(115, 360);
            this.groupBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxGender.Size = new System.Drawing.Size(150, 32);
            this.groupBoxGender.TabIndex = 58;
            this.groupBoxGender.TabStop = false;
            // 
            // groupBoxQ1
            // 
            this.groupBoxQ1.Controls.Add(this.radioButtonNQ1);
            this.groupBoxQ1.Controls.Add(this.radioButtonYQ1);
            this.groupBoxQ1.Location = new System.Drawing.Point(322, 94);
            this.groupBoxQ1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQ1.Name = "groupBoxQ1";
            this.groupBoxQ1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQ1.Size = new System.Drawing.Size(99, 35);
            this.groupBoxQ1.TabIndex = 59;
            this.groupBoxQ1.TabStop = false;
            // 
            // groupBoxQ2
            // 
            this.groupBoxQ2.Controls.Add(this.radioButtonNQ2);
            this.groupBoxQ2.Controls.Add(this.radioButtonYQ2);
            this.groupBoxQ2.Location = new System.Drawing.Point(322, 159);
            this.groupBoxQ2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQ2.Name = "groupBoxQ2";
            this.groupBoxQ2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQ2.Size = new System.Drawing.Size(99, 35);
            this.groupBoxQ2.TabIndex = 60;
            this.groupBoxQ2.TabStop = false;
            // 
            // radioButtonNQ2
            // 
            this.radioButtonNQ2.AutoSize = true;
            this.radioButtonNQ2.Location = new System.Drawing.Point(50, 13);
            this.radioButtonNQ2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNQ2.Name = "radioButtonNQ2";
            this.radioButtonNQ2.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNQ2.TabIndex = 42;
            this.radioButtonNQ2.TabStop = true;
            this.radioButtonNQ2.Text = "No";
            this.radioButtonNQ2.UseVisualStyleBackColor = true;
            // 
            // radioButtonYQ2
            // 
            this.radioButtonYQ2.AutoSize = true;
            this.radioButtonYQ2.Location = new System.Drawing.Point(5, 13);
            this.radioButtonYQ2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYQ2.Name = "radioButtonYQ2";
            this.radioButtonYQ2.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYQ2.TabIndex = 41;
            this.radioButtonYQ2.TabStop = true;
            this.radioButtonYQ2.Text = "Yes";
            this.radioButtonYQ2.UseVisualStyleBackColor = true;
            // 
            // groupBoxQ5
            // 
            this.groupBoxQ5.Controls.Add(this.radioButtonNQ5);
            this.groupBoxQ5.Controls.Add(this.radioButtonYQ5);
            this.groupBoxQ5.Location = new System.Drawing.Point(322, 354);
            this.groupBoxQ5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQ5.Name = "groupBoxQ5";
            this.groupBoxQ5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQ5.Size = new System.Drawing.Size(99, 35);
            this.groupBoxQ5.TabIndex = 61;
            this.groupBoxQ5.TabStop = false;
            // 
            // radioButtonNQ5
            // 
            this.radioButtonNQ5.AutoSize = true;
            this.radioButtonNQ5.Location = new System.Drawing.Point(50, 13);
            this.radioButtonNQ5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNQ5.Name = "radioButtonNQ5";
            this.radioButtonNQ5.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNQ5.TabIndex = 42;
            this.radioButtonNQ5.TabStop = true;
            this.radioButtonNQ5.Text = "No";
            this.radioButtonNQ5.UseVisualStyleBackColor = true;
            // 
            // radioButtonYQ5
            // 
            this.radioButtonYQ5.AutoSize = true;
            this.radioButtonYQ5.Location = new System.Drawing.Point(5, 13);
            this.radioButtonYQ5.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYQ5.Name = "radioButtonYQ5";
            this.radioButtonYQ5.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYQ5.TabIndex = 41;
            this.radioButtonYQ5.TabStop = true;
            this.radioButtonYQ5.Text = "Yes";
            this.radioButtonYQ5.UseVisualStyleBackColor = true;
            // 
            // groupBoxQ4
            // 
            this.groupBoxQ4.Controls.Add(this.radioButtonNQ4);
            this.groupBoxQ4.Controls.Add(this.radioButtonYQ4);
            this.groupBoxQ4.Location = new System.Drawing.Point(322, 289);
            this.groupBoxQ4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQ4.Name = "groupBoxQ4";
            this.groupBoxQ4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQ4.Size = new System.Drawing.Size(99, 35);
            this.groupBoxQ4.TabIndex = 60;
            this.groupBoxQ4.TabStop = false;
            // 
            // radioButtonNQ4
            // 
            this.radioButtonNQ4.AutoSize = true;
            this.radioButtonNQ4.Location = new System.Drawing.Point(50, 13);
            this.radioButtonNQ4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNQ4.Name = "radioButtonNQ4";
            this.radioButtonNQ4.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNQ4.TabIndex = 42;
            this.radioButtonNQ4.TabStop = true;
            this.radioButtonNQ4.Text = "No";
            this.radioButtonNQ4.UseVisualStyleBackColor = true;
            this.radioButtonNQ4.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonYQ4
            // 
            this.radioButtonYQ4.AutoSize = true;
            this.radioButtonYQ4.Location = new System.Drawing.Point(5, 13);
            this.radioButtonYQ4.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYQ4.Name = "radioButtonYQ4";
            this.radioButtonYQ4.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYQ4.TabIndex = 41;
            this.radioButtonYQ4.TabStop = true;
            this.radioButtonYQ4.Text = "Yes";
            this.radioButtonYQ4.UseVisualStyleBackColor = true;
            // 
            // groupBoxQ3
            // 
            this.groupBoxQ3.Controls.Add(this.radioButtonNQ3);
            this.groupBoxQ3.Controls.Add(this.radioButtonYQ3);
            this.groupBoxQ3.Location = new System.Drawing.Point(322, 224);
            this.groupBoxQ3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxQ3.Name = "groupBoxQ3";
            this.groupBoxQ3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxQ3.Size = new System.Drawing.Size(99, 35);
            this.groupBoxQ3.TabIndex = 60;
            this.groupBoxQ3.TabStop = false;
            // 
            // radioButtonNQ3
            // 
            this.radioButtonNQ3.AutoSize = true;
            this.radioButtonNQ3.Location = new System.Drawing.Point(50, 13);
            this.radioButtonNQ3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNQ3.Name = "radioButtonNQ3";
            this.radioButtonNQ3.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNQ3.TabIndex = 42;
            this.radioButtonNQ3.TabStop = true;
            this.radioButtonNQ3.Text = "No";
            this.radioButtonNQ3.UseVisualStyleBackColor = true;
            // 
            // radioButtonYQ3
            // 
            this.radioButtonYQ3.AutoSize = true;
            this.radioButtonYQ3.Location = new System.Drawing.Point(5, 13);
            this.radioButtonYQ3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonYQ3.Name = "radioButtonYQ3";
            this.radioButtonYQ3.Size = new System.Drawing.Size(43, 17);
            this.radioButtonYQ3.TabIndex = 41;
            this.radioButtonYQ3.TabStop = true;
            this.radioButtonYQ3.Text = "Yes";
            this.radioButtonYQ3.UseVisualStyleBackColor = true;
            // 
            // TextboxTestBlood
            // 
            this.TextboxTestBlood.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxTestBlood.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxTestBlood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxTestBlood.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxTestBlood.HintText = "";
            this.TextboxTestBlood.isPassword = false;
            this.TextboxTestBlood.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxTestBlood.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxTestBlood.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.TextboxTestBlood.LineThickness = 3;
            this.TextboxTestBlood.Location = new System.Drawing.Point(86, 393);
            this.TextboxTestBlood.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxTestBlood.Name = "TextboxTestBlood";
            this.TextboxTestBlood.Size = new System.Drawing.Size(119, 27);
            this.TextboxTestBlood.TabIndex = 39;
            this.TextboxTestBlood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonManual
            // 
            this.ButtonManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.ButtonManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonManual.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManual.Location = new System.Drawing.Point(211, 430);
            this.ButtonManual.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonManual.Name = "ButtonManual";
            this.ButtonManual.Size = new System.Drawing.Size(90, 31);
            this.ButtonManual.TabIndex = 62;
            this.ButtonManual.Text = "Manual";
            this.ButtonManual.UseVisualStyleBackColor = false;
            this.ButtonManual.Click += new System.EventHandler(this.ButtonManual_Click);
            // 
            // buttonExistingPatient
            // 
            this.buttonExistingPatient.AllowDrop = true;
            this.buttonExistingPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.buttonExistingPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExistingPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExistingPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExistingPatient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExistingPatient.Location = new System.Drawing.Point(703, 34);
            this.buttonExistingPatient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExistingPatient.Name = "buttonExistingPatient";
            this.buttonExistingPatient.Size = new System.Drawing.Size(134, 31);
            this.buttonExistingPatient.TabIndex = 65;
            this.buttonExistingPatient.Text = "Existing Patient";
            this.buttonExistingPatient.UseVisualStyleBackColor = false;
            this.buttonExistingPatient.Click += new System.EventHandler(this.buttonExistingPatient_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diagnosis,
            this.Recommendation});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(137)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(697, 93);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(241, 417);
            this.bunifuCustomDataGrid1.TabIndex = 66;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Diagnosis
            // 
            this.Diagnosis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.Diagnosis.DefaultCellStyle = dataGridViewCellStyle7;
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.Width = 87;
            // 
            // Recommendation
            // 
            this.Recommendation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(172)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.Recommendation.DefaultCellStyle = dataGridViewCellStyle8;
            this.Recommendation.HeaderText = "Recommendation";
            this.Recommendation.Name = "Recommendation";
            this.Recommendation.Width = 138;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(233)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.buttonExistingPatient);
            this.Controls.Add(this.ButtonManual);
            this.Controls.Add(this.TextboxTestBlood);
            this.Controls.Add(this.groupBoxQ4);
            this.Controls.Add(this.groupBoxQ3);
            this.Controls.Add(this.groupBoxQ5);
            this.Controls.Add(this.groupBoxQ2);
            this.Controls.Add(this.groupBoxQ1);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.buttonDiagnose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelTestBlood);
            this.Controls.Add(this.buttonTestBlood);
            this.Controls.Add(this.TextboxHeartBeat);
            this.Controls.Add(this.TextboxFever);
            this.Controls.Add(this.TextboxWeight);
            this.Controls.Add(this.TextboxHeight);
            this.Controls.Add(this.TextboxAge);
            this.Controls.Add(this.TextboxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextboxID);
            this.Controls.Add(this.TextboxBloodPre);
            this.Controls.Add(this.LabelLastN);
            this.Controls.Add(this.LabelFever);
            this.Controls.Add(this.LabelHeart);
            this.Controls.Add(this.LabelBlood);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.LabelWeight);
            this.Controls.Add(this.LabelFirst);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiagnosisForm";
            this.Text = "DiagnosisForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.groupBoxQ1.ResumeLayout(false);
            this.groupBoxQ1.PerformLayout();
            this.groupBoxQ2.ResumeLayout(false);
            this.groupBoxQ2.PerformLayout();
            this.groupBoxQ5.ResumeLayout(false);
            this.groupBoxQ5.PerformLayout();
            this.groupBoxQ4.ResumeLayout(false);
            this.groupBoxQ4.PerformLayout();
            this.groupBoxQ3.ResumeLayout(false);
            this.groupBoxQ3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFirst;
        private System.Windows.Forms.Label LabelWeight;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label LabelBlood;
        private System.Windows.Forms.Label LabelHeart;
        private System.Windows.Forms.Label LabelFever;
        private System.Windows.Forms.Label LabelLastN;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxBloodPre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxFname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxLname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxHeight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxWeight;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxFever;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxHeartBeat;
        private System.Windows.Forms.Button buttonTestBlood;
        private System.Windows.Forms.Label LabelTestBlood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonYQ1;
        private System.Windows.Forms.RadioButton radioButtonNQ1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDiagnose;
        private Bunifu.Framework.UI.BunifuImageButton ExitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.GroupBox groupBoxQ4;
        private System.Windows.Forms.RadioButton radioButtonNQ4;
        private System.Windows.Forms.RadioButton radioButtonYQ4;
        private System.Windows.Forms.GroupBox groupBoxQ3;
        private System.Windows.Forms.RadioButton radioButtonNQ3;
        private System.Windows.Forms.RadioButton radioButtonYQ3;
        private System.Windows.Forms.GroupBox groupBoxQ5;
        private System.Windows.Forms.RadioButton radioButtonNQ5;
        private System.Windows.Forms.RadioButton radioButtonYQ5;
        private System.Windows.Forms.GroupBox groupBoxQ2;
        private System.Windows.Forms.RadioButton radioButtonNQ2;
        private System.Windows.Forms.RadioButton radioButtonYQ2;
        private System.Windows.Forms.GroupBox groupBoxQ1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxTestBlood;
        private System.Windows.Forms.Button ButtonManual;
        private System.Windows.Forms.Button buttonExistingPatient;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommendation;
    }
}